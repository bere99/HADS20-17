﻿Imports System.Net.Mail

Public Class GestionCorreo
    Sub SendEmail(ByVal destination As String, ByVal subject As String, ByVal body As String)
        Dim passWord = "Amparo4.beretxiki"

        Dim msg = New MailMessage()
        msg.To.Add(New MailAddress(destination, "HADS"))
        msg.From = New MailAddress("ibereciartua003@ikasle.ehu.eus", "HADS")
        msg.Subject = subject
        msg.Body = body
        msg.IsBodyHtml = True
        Dim client = New SmtpClient()
        client.UseDefaultCredentials = False
        client.Credentials = New System.Net.NetworkCredential("873467", passWord)
        client.Port = 587
        client.Host = "smtp.ehu.eus"
        client.DeliveryMethod = SmtpDeliveryMethod.Network
        client.EnableSsl = True
        client.Send(msg)

    End Sub

End Class
