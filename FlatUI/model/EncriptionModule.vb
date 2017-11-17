﻿Imports System
Imports System.IO
Imports System.Security
Imports System.Security.Cryptography

Public Class EncryptionModule

#Region "1. Global Variables "

    '*************************
    '** Global Variables
    '*************************

    Dim strFileToEncrypt As String
    Dim strFileToDecrypt As String
    Dim strOutputEncrypt As String
    Dim strOutputDecrypt As String
    Dim fsInput As System.IO.FileStream
    Dim fsOutput As System.IO.FileStream

#End Region

#Region "2. Create A Key "

    '*************************
    '** Create A Key
    '*************************

    Public Function CreateKey(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytKey(31).  It will hold 256 bits.
        Dim bytKey(31) As Byte

        'Use For Next to put a specific size (256 bits) of 
        'bytResult into bytKey. The 0 To 31 will put the first 256 bits
        'of 512 bits into bytKey.
        For i As Integer = 0 To 31
            bytKey(i) = bytResult(i)
        Next

        Return bytKey 'Return the key.
    End Function

#End Region

#Region "3. Create An IV "

    '*************************
    '** Create An IV
    '*************************

    Public Function CreateIV(ByVal strPassword As String) As Byte()
        'Convert strPassword to an array and store in chrData.
        Dim chrData() As Char = strPassword.ToCharArray
        'Use intLength to get strPassword size.
        Dim intLength As Integer = chrData.GetUpperBound(0)
        'Declare bytDataToHash and make it the same size as chrData.
        Dim bytDataToHash(intLength) As Byte

        'Use For Next to convert and store chrData into bytDataToHash.
        For i As Integer = 0 To chrData.GetUpperBound(0)
            bytDataToHash(i) = CByte(Asc(chrData(i)))
        Next

        'Declare what hash to use.
        Dim SHA512 As New System.Security.Cryptography.SHA512Managed
        'Declare bytResult, Hash bytDataToHash and store it in bytResult.
        Dim bytResult As Byte() = SHA512.ComputeHash(bytDataToHash)
        'Declare bytIV(15).  It will hold 128 bits.
        Dim bytIV(15) As Byte

        'Use For Next to put a specific size (128 bits) of 
        'bytResult into bytIV. The 0 To 30 for bytKey used the first 256 bits.
        'of the hashed password. The 32 To 47 will put the next 128 bits into bytIV.
        For i As Integer = 32 To 47
            bytIV(i - 32) = bytResult(i)
        Next

        Return bytIV 'return the IV
    End Function

#End Region

#Region "4. Encrypt / Decrypt File "

    '****************************
    '** Encrypt/Decrypt File
    '****************************

    Public Enum CryptoAction
        'Define the enumeration for CryptoAction.
        ActionEncrypt = 1
        ActionDecrypt = 2
    End Enum

    Public Sub EncryptOrDecryptFile(ByVal strInputFile As String,
                                     ByVal strOutputFile As String,
                                     ByVal bytKey() As Byte,
                                     ByVal bytIV() As Byte,
                                     ByVal Direction As CryptoAction)
        Try 'In case of errors.

            'Setup file streams to handle input and output.
            fsInput = New System.IO.FileStream(strInputFile, FileMode.Open,
                                               FileAccess.Read)
            fsOutput = New System.IO.FileStream(strOutputFile, FileMode.OpenOrCreate,
                                                FileAccess.Write)
            fsOutput.SetLength(0) 'make sure fsOutput is empty

            'Declare variables for encrypt/decrypt process.
            Dim bytBuffer(4096) As Byte 'holds a block of bytes for processing
            Dim lngBytesProcessed As Long = 0 'running count of bytes processed
            Dim lngFileLength As Long = fsInput.Length 'the input file's length
            Dim intBytesInCurrentBlock As Integer 'current bytes being processed
            Dim csCryptoStream As CryptoStream
            'Declare your CryptoServiceProvider.
            Dim cspRijndael As New System.Security.Cryptography.RijndaelManaged
            'Setup Progress Bar
            'pbStatus.Value = 0
            'pbStatus.Maximum = 100

            'Determine if ecryption or decryption and setup CryptoStream.
            Select Case Direction
                Case CryptoAction.ActionEncrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateEncryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)

                Case CryptoAction.ActionDecrypt
                    csCryptoStream = New CryptoStream(fsOutput,
                    cspRijndael.CreateDecryptor(bytKey, bytIV),
                    CryptoStreamMode.Write)
            End Select

            'Use While to loop until all of the file is processed.
            While lngBytesProcessed < lngFileLength
                'Read file with the input filestream.
                intBytesInCurrentBlock = fsInput.Read(bytBuffer, 0, 4096)
                'Write output file with the cryptostream.
                csCryptoStream.Write(bytBuffer, 0, intBytesInCurrentBlock)
                'Update lngBytesProcessed
                lngBytesProcessed = lngBytesProcessed + CLng(intBytesInCurrentBlock)
                'Update Progress Bar
                'pbStatus.Value = CInt((lngBytesProcessed / lngFileLength) * 100)
            End While

            'Close FileStreams and CryptoStream.
            csCryptoStream.Close()
            fsInput.Close()
            fsOutput.Close()

            'If encrypting then delete the original unencrypted file.
            'If Direction = CryptoAction.ActionEncrypt Then
            'Dim fileOriginal As New FileInfo(strFileToEncrypt)
            'fileOriginal.Delete()
            'End If

            'If decrypting then delete the encrypted file.
            'If Direction = CryptoAction.ActionDecrypt Then
            'Dim fileEncrypted As New FileInfo(strFileToDecrypt)
            'fileEncrypted.Delete()
            'End If

            'Update the user when the file is done.
            'Dim Wrap As String = Chr(13) + Chr(10)
            'If Direction = CryptoAction.ActionEncrypt Then
            'MsgBox("Encryption Complete" + Wrap + Wrap +
            '           "Total bytes processed = " +
            'lngBytesProcessed.ToString,
            'MsgBoxStyle.Information, "Done")

            'Update the progress bar and textboxes.
            'pbStatus.Value = 0
            'txtFileToEncrypt.Text = "Click Browse to load file."
            'txtPassEncrypt.Text = ""
            'txtConPassEncrypt.Text = ""
            'txtDestinationEncrypt.Text = ""
            'btnChangeEncrypt.Enabled = False
            'btnEncrypt.Enabled = False

            'Else
            'Update the user when the file is done.
            'MsgBox("Decryption Complete" + Wrap + Wrap +
            '          "Total bytes processed = " +
            'lngBytesProcessed.ToString,
            'MsgBoxStyle.Information, "Done")

            'Update the progress bar and textboxes.
            'pbStatus.Value = 0
            'txtFileToDecrypt.Text = "Click Browse to load file."
            'txtPassDecrypt.Text = ""
            'txtConPassDecrypt.Text = ""
            'txtDestinationDecrypt.Text = ""
            'btnChangeDecrypt.Enabled = False
            'btnDecrypt.Enabled = False
            '            End If


            'Catch file not found error.
        Catch When Err.Number = 53 'if file not found
            MsgBox("Please check to make sure the path and filename" +
                    "are correct and if the file exists.",
                     MsgBoxStyle.Exclamation, "Invalid Path or Filename")

            'Catch all other errors. And delete partial files.
        Catch ex As Exception
            fsInput.Close()
            fsOutput.Close()
            Console.WriteLine(ex.ToString)
            If Direction = CryptoAction.ActionDecrypt Then
                'Dim fileDelete As New FileInfo(txtDestinationDecrypt.Text)
                'fileDelete.Delete()
                'pbStatus.Value = 0
                'txtPassDecrypt.Text = ""
                'txtConPassDecrypt.Text = ""

                MsgBox("Please check to make sure that you entered the correct" +
                        "password.", MsgBoxStyle.Exclamation, "Invalid Password")
            Else
                'Dim fileDelete As New FileInfo(txtDestinationEncrypt.Text)
                'fileDelete.Delete()

                'pbStatus.Value = 0
                'txtPassEncrypt.Text = ""
                'txtConPassEncrypt.Text = ""

                MsgBox("This file cannot be encrypted.",
                        MsgBoxStyle.Exclamation, "Invalid File")

            End If

        End Try
    End Sub

#End Region


End Class
