Imports System.IO.Ports

Public Class Form1
    Dim merda As String
    Dim drag As Boolean = False
    Dim mousex As Integer, mousey As Integer
    Dim psx As String

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
        End If
    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Close()

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        psx = SerialPort1.ReadLine()

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Label3.Text = psx
        If SerialArduino.IsOpen Then
            SerialArduino.WriteLine(Label4.Text)
        End If







    End Sub



    Private Sub Label3_TextChanged(sender As Object, e As EventArgs) Handles Label3.TextChanged

        If Label3.Text = 512 Then
            merda = "g"
            PictureBox9.Visible = True
            PictureBox13.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox9.Visible = False
            PictureBox13.Visible = False
        End If
        If Label3.Text = 2048 Then
            merda = "e"
            PictureBox3.Visible = True
            PictureBox14.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox3.Visible = False
            PictureBox14.Visible = False
        End If
        If Label3.Text = 256 Then
            merda = "h"
            PictureBox8.Visible = True
            PictureBox16.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox8.Visible = False
            PictureBox16.Visible = False
        End If
        If Label3.Text = 1024 Then
            merda = "f"
            PictureBox5.Visible = True
            PictureBox15.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox5.Visible = False
            PictureBox15.Visible = False
        End If

        If Label3.Text = 8 Then
            merda = "a"
            PictureBox4.Visible = True
            PictureBox11.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox4.Visible = False
            PictureBox11.Visible = False
        End If

        If Label3.Text = 2 Then
            merda = "c"
            PictureBox12.Visible = True
            PictureBox10.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox12.Visible = False
            PictureBox10.Visible = False
        End If

        If Label3.Text = 1 Then
            merda = "d"
            PictureBox7.Visible = True
            PictureBox17.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox7.Visible = False
            PictureBox17.Visible = False
        End If

        If Label3.Text = 4 Then
            merda = "b"
            PictureBox6.Visible = True
            PictureBox18.Visible = True
            Label4.Text = merda
        Else
            merda = ""
            PictureBox6.Visible = False
            PictureBox18.Visible = False
        End If

        If Label3.Text = 128 Then
            merda = "i"
            PictureBox19.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox19.Visible = False

        End If

        If Label3.Text = 16 Then
            merda = "l"
            PictureBox20.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox20.Visible = False

        End If

        If Label3.Text = 4096 Then
            merda = "m"
            PictureBox24.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox24.Visible = False

        End If

        If Label3.Text = 16384 Then
            merda = "n"
            PictureBox25.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox25.Visible = False

        End If

        If Label3.Text = 8192 Then
            merda = "o"
            PictureBox22.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox22.Visible = False

        End If

        If Label3.Text = 32768 Then
            merda = "p"
            PictureBox23.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox23.Visible = False
        End If

        If Label3.Text = 1152 Then  ''select + cerchio
            merda = "A"
            PictureBox19.Visible = True
            PictureBox15.Visible = True
            PictureBox5.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox19.Visible = False
            PictureBox15.Visible = False
            PictureBox5.Visible = False
        End If

        If Label3.Text = 384 Then  ''select + quadrato
            merda = "B"
            PictureBox19.Visible = True
            PictureBox16.Visible = True
            PictureBox8.Visible = True
            Label4.Text = merda

        Else
            merda = ""
            PictureBox19.Visible = False
            PictureBox16.Visible = False
            PictureBox8.Visible = False
        End If






        ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        If Label3.Text = 0 Then
            merda = "0"

            Label4.Text = merda
        End If






    End Sub

    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        SerialPort1.PortName = ComboBox1.Text
        SerialPort1.Close()
        SerialPort1.Open()


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ComboBox2_TextChanged(sender As Object, e As EventArgs) Handles ComboBox2.TextChanged
        SerialArduino.PortName = ComboBox2.Text
        SerialArduino.Close()
        SerialArduino.Open()




    End Sub


End Class

