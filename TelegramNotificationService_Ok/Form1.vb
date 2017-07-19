Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conn As New MySqlConnection
    Dim serdata As String
    Dim vartoken As String
    Dim varchatid As String
    Dim tempport As String
    Dim jsondata As String
    Dim cmd As New MySqlCommand
    Dim DR As MySqlDataReader
    Dim DatabaseName As String = "db_telegram"
    Dim server As String = "127.0.0.1"
    Dim userName As String = "root"
    Dim password As String = ""

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cbbaudrate.Items.Add(9600)
        cbbaudrate.Items.Add(19200)
        cbbaudrate.Items.Add(38400)
        cbbaudrate.Items.Add(57600)
        cbbaudrate.Items.Add(115200)
        cbportfill()
        btdisconnect.Enabled = False
        connect()
    End Sub

    Private Sub btconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btconnect.Click
        If cbport.Text = "" Then
            MessageBox.Show("You must select port first..")
        ElseIf cbbaudrate.Text = "" Then
            MessageBox.Show("You must select baud rate first..")
        Else
            vartoken = "369348634:AAFQsPBjnmNziAMs00CwKbPfE00igQ4h260"
            varchatid = "248735818"
            tempport = cbport.Text
            cbport.Items.Clear()
            cbportfill()
            If cbport.Items.Contains(tempport) Then
                'Do nothing
                cbport.Enabled = False
                cbbaudrate.Enabled = False
                SerialPort1.PortName = cbport.Text
                SerialPort1.BaudRate = cbbaudrate.Text
                btconnect.Enabled = False
                SerialPort1.Open()
                btrefresh.Enabled = False
                btdisconnect.Enabled = True
                Timer1.Enabled = True
            Else
                MessageBox.Show("Port " & tempport & " unavailable")
                cbport.Text = ""
                cbport.Items.Clear()
            End If
        End If
    End Sub

    Private Sub btdisconnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btdisconnect.Click
        btdisconnect.Enabled = False
        Timer1.Enabled = False
        SerialPort1.Close()
        btconnect.Enabled = True
        btrefresh.Enabled = True
        cbport.Enabled = True
        cbbaudrate.Enabled = True
        RichTextBox1.Text = ""
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If SerialPort1.IsOpen Then
            'SerialPort1.Write(Chr(1))
            serdata = SerialPort1.ReadExisting
            RichTextBox1.Text = serdata
            If RichTextBox1.Text = "" Then
                'Do nothing here
            Else
                Dim req As Net.HttpWebRequest = Net.WebRequest.Create("https://api.telegram.org/bot" & vartoken & "/sendMessage?chat_id=" & varchatid & "&text=" & serdata)

                Dim response As Net.WebResponse = req.GetResponse

                Dim stream As System.IO.Stream = response.GetResponseStream

                'Prepare buffer for reading from stream
                Dim buffer As Byte() = New Byte(1000) {}

                'Data read from stream is gathered here
                Dim data As New List(Of Byte)

                'Start reading stream
                Dim bytesRead = stream.Read(buffer, 0, buffer.Length)

                Do Until bytesRead = 0
                    For i = 0 To bytesRead - 1
                        data.Add(buffer(i))
                    Next

                    bytesRead = stream.Read(buffer, 0, buffer.Length)
                Loop

                'Gets the JSON data
                'Debug.WriteLine(System.Text.Encoding.UTF8.GetString(data.ToArray))
                jsondata = System.Text.Encoding.UTF8.GetString(data.ToArray)
                RichTextBox2.Text = jsondata
                filljsontodb()
                response.Close()
                stream.Close()
                WebBrowser1.Navigate("http://localhost/telegram/page/home.php")
                WebBrowser1.ScrollBarsEnabled = False
                WebBrowser1.Show()
            End If
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub btrefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btrefresh.Click
        refreshform()
    End Sub

    Public Sub cbportfill()
        For i As Integer = 0 To My.Computer.Ports.SerialPortNames.Count - 1
            cbport.Items.Add(My.Computer.Ports.SerialPortNames(i))
        Next
    End Sub

    Public Sub refreshform()
        cbport.Text = ""
        cbport.Items.Clear()
        cbportfill()
        btdisconnect.Enabled = False
    End Sub

    Public Sub connect()
        Dim DatabaseName As String = "db_telegram"
        Dim server As String = "127.0.0.1"
        Dim userName As String = "root"
        Dim password As String = ""
        If Not conn Is Nothing Then conn.Close()
        conn.ConnectionString = String.Format("server={0}; user id={1}; password={2}; database={3}; pooling=false", server, userName, password, DatabaseName)
        Try
            conn.Open()
            Label5.ForeColor = Color.Green
            Label5.Text = "Sucsessfully connected to database"
        Catch ex As Exception
            Label5.ForeColor = Color.Red
            Label5.Text = "Warning : " & ex.Message
        End Try
        conn.Close()
    End Sub

    Public Sub filljsontodb()
        conn.Open()
        cmd.Connection = conn
        cmd.CommandText = "SELECT * FROM `json_data` WHERE 1"
        DR = cmd.ExecuteReader
        If DR.HasRows Then
            cmd.CommandText = "DELETE FROM `json_data` WHERE 1"
            DR.Close()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            cmd.CommandText = "INSERT INTO `json_data`(`json`) VALUES ('" & jsondata & "')"
            DR.Close()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        Else
            cmd.CommandText = "INSERT INTO `json_data`(`json`) VALUES ('" & jsondata & "')"
            DR.Close()
            Try
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            conn.Close()
        End If
    End Sub
End Class
