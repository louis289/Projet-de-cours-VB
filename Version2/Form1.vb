
Imports System.Data.Common
Imports System.IO.Ports

Public Class Form1
    Dim ledStates(7, 69) As Boolean

    Dim ledSizeX As Integer = 10
    Dim ledSizeY As Integer = 50
    Dim spacingY As Integer = 20
    Dim startX As Integer = 50
    Dim startY As Integer = 50

    Dim isMouseDown As Boolean = False
    Dim startColumn As Integer = 0
    Dim startRow As Integer = 0
    Dim isMouseLeft As Boolean = False
    Dim isMouseRight As Boolean = False

    Dim k As Integer = 0 'curseur noir

    Dim port_com As IO.Ports.SerialPort 'Pour l'arduino

    Dim arduinoConnected As Boolean = False


    Dim red_cursor_speed As Integer = 500
    Dim red_cursor_base_speed As Integer = 500
    Dim red_cursor_visibility As Boolean = False
    Dim red_cursor_position As Integer = 0

    Dim speed_scrollbar As Int16

    Dim pause_value As Boolean = 0


    Dim initSequence As Integer(,) = {
            {1, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 1, 0, 1},
            {0, 1, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 1},
            {0, 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 1},
            {0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 0, 1},
            {0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 1, 0, 1},
            {0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 1, 0, 1},
            {0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 1, 0, 0, 1},
            {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 1, 0, 0, 1}
            }

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Contrôle des LEDs"
        InitializeLeds()
        Label4.Text = "vitesse : " & red_cursor_speed & " ms"
        Label5.Text = "valeur"
        Label1.Text = "valeur curseur : " & k
        Label2.Text = "Position souris"
        Label3.Text = "coordonnées clic souris"
        Try
            port_com = New IO.Ports.SerialPort
            port_com.PortName = "COM5" ' ← adapte si besoin
            port_com.BaudRate = 9600
            port_com.Open()
            arduinoConnected = True
        Catch ex As Exception
            arduinoConnected = False
            MessageBox.Show("Mode non connecté : Arduino non détecté sur COM5", "Mode dégradé", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub


    Private Sub InitializeLeds()
        For i As Integer = 0 To 7
            For j As Integer = 0 To 69
                ledStates(i, j) = False
            Next
        Next
        Invalidate()
    End Sub



    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics

        Dim colorVoy(8) As Color

        For i As Integer = 0 To 7
            colorVoy(i) = If(ledStates(i, k), If(i = 0, Color.Green, Color.Yellow), Color.Black)

            For j As Integer = 0 To 69
                Dim color As Color = If(ledStates(i, j), If(i = 0, Color.Green, Color.Yellow), Color.Black)
                g.FillRectangle(New SolidBrush(color), startX + (j * ledSizeX), startY + (i * (ledSizeY + spacingY)), ledSizeX, ledSizeY)
            Next
            'g.FillRectangle(New SolidBrush(colorVoy), startX + (50 * ledSizeX) + 50, startY + (i * (ledSizeY + spacingY)), ledSizeY, ledSizeY)

        Next



        LED1.BackColor = colorVoy(0)
        LED2.BackColor = colorVoy(1)
        LED3.BackColor = colorVoy(2)
        LED4.BackColor = colorVoy(3)
        LED5.BackColor = colorVoy(4)
        LED6.BackColor = colorVoy(5)
        LED7.BackColor = colorVoy(6)
        LED8.BackColor = colorVoy(7)




    End Sub



    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        startColumn = (e.X - startX) \ ledSizeX
        startRow = (e.Y - startY + spacingY \ 2) \ (ledSizeY + spacingY)
        If startColumn >= 0 AndAlso startColumn < 70 AndAlso startRow >= 0 AndAlso startRow < 8 Then
            If e.Button = MouseButtons.Left Then
                isMouseLeft = True
                isMouseRight = False
            ElseIf e.Button = MouseButtons.Right Then
                isMouseLeft = False
                isMouseRight = True
            End If
            isMouseDown = True
        End If

        Label3.Text = "ligne départ : " & startRow & "
colone départ : " & startColumn
    End Sub

    Private Sub Form1_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If isMouseDown Then
            Dim endColumn As Integer = (e.X - startX) \ ledSizeX
            If endColumn >= 0 AndAlso endColumn < 70 Then
                If endColumn < startColumn Then
                    Dim temp As Integer = startColumn
                    startColumn = endColumn
                    endColumn = temp
                End If

                For i As Integer = startColumn To endColumn
                    If isMouseLeft AndAlso Not isMouseRight Then
                        ledStates(startRow, i) = True
                    ElseIf Not isMouseLeft AndAlso isMouseRight Then
                        ledStates(startRow, i) = False
                    End If
                Next
            End If

            Me.Invalidate()
            isMouseDown = False
        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnMiseA0.Click, MiseÀ0ToolStripMenuItem.Click
        InitializeLeds()
    End Sub

    Private Sub BtnMiseA1_Click(sender As Object, e As EventArgs) Handles BtnMiseA1.Click, MiseÀ1ToolStripMenuItem.Click
        For i = 0 To 7
            For j = 0 To 69
                ledStates(i, j) = True
            Next
        Next
        Invalidate()
    End Sub

    Private Sub BtnInitialisation_Click(sender As Object, e As EventArgs) Handles BtnInitialisation.Click, InitialisationToolStripMenuItem.Click

        For i = 0 To 7
            For j = 0 To 13
                For l = 0 To 4
                    ledStates(i, j * 5 + l) = initSequence(i, j)
                Next
            Next
        Next
        Invalidate()
    End Sub

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        k = HScrollBar1.Value
        Label1.Text = "valeur curseur : " & k

        BlackCursor.Left = 50 + ledSizeX * k + 4

    End Sub

    Private Sub LED1_Click(sender As Object, e As EventArgs) Handles LED1.Click
        ledStates(0, k) = Not ledStates(0, k)
        Invalidate()
    End Sub

    Private Sub LED2_Click(sender As Object, e As EventArgs) Handles LED2.Click
        ledStates(1, k) = Not ledStates(1, k)
        Me.Invalidate()
    End Sub

    Private Sub LED3_Click(sender As Object, e As EventArgs) Handles LED3.Click
        ledStates(2, k) = Not ledStates(2, k)
        Me.Invalidate()
    End Sub

    Private Sub LED4_Click(sender As Object, e As EventArgs) Handles LED4.Click
        ledStates(3, k) = Not ledStates(3, k)
        Invalidate()
    End Sub

    Private Sub LED5_Click(sender As Object, e As EventArgs) Handles LED5.Click
        ledStates(4, k) = Not ledStates(4, k)
        Invalidate()
    End Sub

    Private Sub LED6_Click(sender As Object, e As EventArgs) Handles LED6.Click
        ledStates(5, k) = Not ledStates(5, k)
        Invalidate()
    End Sub

    Private Sub LED7_Click(sender As Object, e As EventArgs) Handles LED7.Click
        ledStates(6, k) = Not ledStates(6, k)
        Invalidate()
    End Sub

    Private Sub LED8_Click(sender As Object, e As EventArgs) Handles LED8.Click
        ledStates(7, k) = Not ledStates(7, k)
        Invalidate()
    End Sub


    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        Dim Column = (e.X - startX) \ ledSizeX
        Dim Row = (e.Y - startY + spacingY \ 2) \ (ledSizeY + spacingY)
        If Column >= 0 AndAlso Column < 70 AndAlso Row >= 0 AndAlso Row < 8 Then
            Label2.Text = "Position actuelle " & Row & " " & Column

        End If


    End Sub

    Private Sub Vitesse_red_cursor_Scroll(sender As Object, e As ScrollEventArgs) Handles Vitesse_red_cursor.Scroll
        speed_scrollbar = Vitesse_red_cursor.Value
        red_cursor_speed = red_cursor_base_speed - speed_scrollbar
        Label4.Text = "vitesse : " & red_cursor_speed & " ms"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Interval = red_cursor_speed

        If red_cursor_position <= 69 Then
            RedCursor.Left = 50 + red_cursor_position * ledSizeX + 4
            red_cursor_position += 1

            RedCursor.Visible = 1

            LED1RadioButton.Checked = ledStates(0, red_cursor_position - 1)
            LED2RadioButton.Checked = ledStates(1, red_cursor_position - 1)
            LED3RadioButton.Checked = ledStates(2, red_cursor_position - 1)
            LED4RadioButton.Checked = ledStates(3, red_cursor_position - 1)
            LED5RadioButton.Checked = ledStates(4, red_cursor_position - 1)
            LED6RadioButton.Checked = ledStates(5, red_cursor_position - 1)
            LED7RadioButton.Checked = ledStates(6, red_cursor_position - 1)
            LED8RadioButton.Checked = ledStates(7, red_cursor_position - 1)

            ProgressBar1.Value = red_cursor_position - 1
            Dim valeur As Integer = -(LED1RadioButton.Checked * 128 + LED2RadioButton.Checked * 64 + LED3RadioButton.Checked * 32 + LED4RadioButton.Checked * 16 + LED5RadioButton.Checked * 8 + LED6RadioButton.Checked * 4 + LED7RadioButton.Checked * 2 + LED8RadioButton.Checked * 1)
            'envoyer valeur a un arduino branché en port serie usb
            Label5.Text = "valeur " & red_cursor_position - 1 & " : " & valeur

            If arduinoConnected Then
                Try
                    port_com.Write(Hex(valeur) & "*")
                Catch ex As Exception
                    MessageBox.Show("Erreur lors de l'envoi au port COM : " & ex.Message, "Erreur COM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    arduinoConnected = False ' On repasse en mode non connecté si problème
                End Try
            End If

            'port_com.Write("[" &
            'If (ledStates(0, red_cursor_position), "1", "0") &
            'If (ledStates(1, red_cursor_position), "1", "0") &
            'If (ledStates(2, red_cursor_position), "1", "0") &
            'If (ledStates(3, red_cursor_position), "1", "0") &
            '   "]"Then)



        Else
            RedCursor.Visible = 0
            red_cursor_position = 0
            RedCursor.Left = 50 + red_cursor_position * ledSizeX + 4
            Timer1.Enabled = 0

            LED1RadioButton.Checked = 0
            LED2RadioButton.Checked = 0
            LED3RadioButton.Checked = 0
            LED4RadioButton.Checked = 0
            LED5RadioButton.Checked = 0
            LED6RadioButton.Checked = 0
            LED7RadioButton.Checked = 0
            LED8RadioButton.Checked = 0
            ProgressBar1.Value = 0
            Label5.Text = "fin"

        End If








    End Sub

    Private Sub RemiseA0_Click(sender As Object, e As EventArgs) Handles RemiseA0.Click, RemiseÀ0ToolStripMenuItem.Click
        red_cursor_position = 0
        RedCursor.Left = 50 + red_cursor_position * ledSizeX + 4
        ProgressBar1.Value = red_cursor_position

    End Sub

    Private Sub pause_Click(sender As Object, e As EventArgs) Handles pause.Click, PauseToolStripMenuItem.Click

        Timer1.Enabled = 0

    End Sub

    Private Sub stopBtn_Click(sender As Object, e As EventArgs) Handles stopBtn.Click, StopToolStripMenuItem.Click
        RedCursor.Visible = 0
        red_cursor_position = 0
        RedCursor.Left = 50 + red_cursor_position * ledSizeX + 4
        Timer1.Enabled = 0

        LED1RadioButton.Checked = 0
        LED2RadioButton.Checked = 0
        LED3RadioButton.Checked = 0
        LED4RadioButton.Checked = 0
        ProgressBar1.Value = red_cursor_position
        Label5.Text = "fin"
        If arduinoConnected Then
            Try
                port_com.Write(Hex(0))
            Catch ex As Exception
                MessageBox.Show("Erreur lors de l'envoi au port COM (stop) : " & ex.Message, "Erreur COM", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub marche_Click(sender As Object, e As EventArgs) Handles marche.Click, MarcheToolStripMenuItem.Click
        RedCursor.Visible = 1
        Timer1.Enabled = 1
    End Sub

    Private Sub remi(sender As Object, e As EventArgs)

    End Sub

    Private Sub pau(sender As Object, e As EventArgs)

    End Sub

    Private Sub remise(sender As Object, e As EventArgs)

    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click

        Dim monFichier As System.IO.StreamWriter

        'SaveFileDialog1.ShowDialog()
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            monFichier = My.Computer.FileSystem.OpenTextFileWriter(SaveFileDialog1.FileName, False)
            For i = 0 To 7
                For j = 0 To 69

                    monFichier.WriteLine(ledStates(i, j))

                Next
            Next
            monFichier.Close()
        End If




    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Dim monFichier As System.IO.StreamReader
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            monFichier = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
            For i = 0 To 7
                For j = 0 To 69

                    ledStates(i, j) = monFichier.ReadLine

                Next
            Next
            monFichier.Close()
            Me.Invalidate()

        End If
        Dim colorVoy(4) As Color

        For i As Integer = 0 To 7
            colorVoy(i) = If(ledStates(i, k), If(i = 0, Color.Green, Color.Yellow), Color.Black)

        Next
        LED1.BackColor = colorVoy(0)
        LED2.BackColor = colorVoy(1)
        LED3.BackColor = colorVoy(2)
        LED4.BackColor = colorVoy(3)



    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles LED6.Click

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles LED8RadioButton.CheckedChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
