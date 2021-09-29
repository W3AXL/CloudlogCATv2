Public Class Form1
    'OmniRig events WithEvents
    Dim WithEvents OmniRigEngine As OmniRig.OmniRigX
    Dim Rig As OmniRig.RigX
    Dim OurRigNo As Integer

    'Thread-Safe Calls To Windows Forms Controls
    Delegate Sub ShowRigStatusDelegate()
    Delegate Sub ShowRigParamsDelegate()

    ' Constants for enum RigParamX
    Const PM_UNKNOWN = &H1
    Const PM_FREQ = &H2
    Const PM_FREQA = &H4
    Const PM_FREQB = &H8
    Const PM_PITCH = &H10
    Const PM_RITOFFSET = &H20
    Const PM_RIT0 = &H40
    Const PM_VFOAA = &H80
    Const PM_VFOAB = &H100
    Const PM_VFOBA = &H200
    Const PM_VFOBB = &H400
    Const PM_VFOA = &H800
    Const PM_VFOB = &H1000
    Const PM_VFOEQUAL = &H2000
    Const PM_VFOSWAP = &H4000
    Const PM_SPLITON = &H8000
    Const PM_SPLITOFF = &H10000
    Const PM_RITON = &H20000
    Const PM_RITOFF = &H40000
    Const PM_XITON = &H80000
    Const PM_XITOFF = &H100000
    Const PM_RX = &H200000
    Const PM_TX = &H400000
    Const PM_CW_U = &H800000
    Const PM_CW_L = &H1000000
    Const PM_SSB_U = &H2000000
    Const PM_SSB_L = &H4000000
    Const PM_DIG_U = &H8000000
    Const PM_DIG_L = &H10000000
    Const PM_AM = &H20000000
    Const PM_FM = &H40000000

    ' Constants for enum RigStatusX
    Const ST_NOTCONFIGURED = &H0
    Const ST_DISABLED = &H1
    Const ST_PORTBUSY = &H2
    Const ST_NOTRESPONDING = &H3
    Const ST_ONLINE = &H4

    'Form LOAD events
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        ' Set Status Bar Information
        lblCloudlogStatus.Text = "Cloudlog Not Connected"

        If (My.Settings.TransverterEnabled = True) Then
            TransverterOffsetToolStripMenuItem.Checked = True
        End If

        StartOmniRig()
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs)
        StopOmniRig()
    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    'OmniRig StatusChange events
    Private Sub OmniRigEngine_StatusChange(ByVal RigNumber As Long) Handles OmniRigEngine.StatusChange
        If RigNumber = OurRigNo Then Invoke(New ShowRigStatusDelegate(AddressOf ShowRigStatus))
    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    'OmniRig ParamsChange events
    Private Sub OmniRigEngine_ParamsChange(ByVal RigNumber As Long, ByVal Params As Long) Handles OmniRigEngine.ParamsChange
        If RigNumber = OurRigNo Then Invoke(New ShowRigParamsDelegate(AddressOf ShowRigParams))
    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    Private Sub ShowRigStatus()
        If Rig Is Nothing Then Exit Sub
        lblRigStatus.Text = Rig.StatusStr
    End Sub

    'Thread-Safe Calls To Windows Forms Controls
    Private Sub ShowRigParams()


        If Rig Is Nothing Then Exit Sub

        Dim newfreq As String

        If (My.Settings.TransverterEnabled = True) Then
            If (My.Settings.TransverterOffsetType = "Plus") Then
                newfreq = Rig.Freq + My.Settings.TransverterFreq
            Else
                newfreq = Rig.Freq - My.Settings.TransverterFreq
            End If

            lblRigFreq.Text = newfreq
        Else
            newfreq = Rig.Freq
            lblRigFreq.Text = Rig.Freq 'Rig.GetRxFrequency
        End If

        Select Case Rig.Mode
            Case PM_CW_L
                lblRigMode.Text = "CW"
            Case PM_CW_U
                lblRigMode.Text = "CW"
            Case PM_SSB_L
                lblRigMode.Text = "SSB"
            Case PM_SSB_U
                lblRigMode.Text = "SSB"
            Case PM_DIG_U
                lblRigMode.Text = "DIGI"
            Case PM_DIG_L
                lblRigMode.Text = "DIGI"
            Case PM_AM
                lblRigMode.Text = "AM"
            Case PM_FM
                lblRigMode.Text = "FM"
            Case Else
                lblRigMode.Text = "Other"
        End Select

        'Connect to Cloudlog API and sync frequency
        If My.Settings.CloudlogURL IsNot Nothing Then
            Try
                Using client As New Net.WebClient
                    System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12

                    Dim RadioName As String = Rig.RigType

                    Dim timestamp As String = DateTime.UtcNow.ToString("yyyy/MM/dd HH:mm:ss")

                    Dim myString As String = "{""radio"": """ + RadioName + """, ""frequency"": """ + newfreq.ToString + """, ""mode"": """ + lblRigMode.Text + """, ""timestamp"": """ + timestamp + """, ""key"": """ + My.Settings.CloudlogAPIKey + """}"

                    Try
                        Dim responsebytes = client.UploadString(My.Settings.CloudlogURL + "/index.php/api/radio", myString)
                        lblCloudlogStatus.Text = "Cloudlog Synced: " + timestamp
                    Catch ex As Exception
                        lblCloudlogStatus.Text = "Cloudlog Synced: Failed, check URL/API"
                    End Try
                End Using
            Catch ex As System.Net.WebException
                lblCloudlogStatus.Text = "Cloudlog Synced: Failed"
            End Try
        End If
    End Sub

    'Procedures
    Private Sub StartOmniRig()

        ' Make sure omnirig is loaded
        If Not OmniRigEngine Is Nothing Then Exit Sub
        OmniRigEngine = CreateObject("OmniRig.OmniRigX")

        Debug.Print("OmniRig version: " + OmniRigEngine.InterfaceVersion.ToString())

        ' we want OmniRig interface V2.1
        If OmniRigEngine.InterfaceVersion < &H101 Then GoTo Error1

        ' Populate the radio dropdown and select the first rig
        fldRigSelection.Items.Add("1: " + OmniRigEngine.Rig1.RigType)
        fldRigSelection.Items.Add("2: " + OmniRigEngine.Rig2.RigType)
        fldRigSelection.Items.Add("3: " + OmniRigEngine.Rig3.RigType)
        fldRigSelection.Items.Add("4: " + OmniRigEngine.Rig4.RigType)
        fldRigSelection.SelectedIndex = 0

        ' Select rig 1
        SelectRig(1)

        Exit Sub
Error1:
        ' report problems
        OmniRigEngine = Nothing
        MsgBox("OmniRig Is Not installed Or has a wrong version number")

    End Sub

    Private Sub StopOmniRig()
        Rig = Nothing
        OmniRigEngine = Nothing
    End Sub

    Private Sub SelectRig(NewRigNo As Integer)
        If OmniRigEngine Is Nothing Then Exit Sub
        OurRigNo = NewRigNo
        Select Case NewRigNo
            Case 1
                Rig = OmniRigEngine.Rig1
            Case 2
                Rig = OmniRigEngine.Rig2
        End Select
        ShowRigStatus()
        ShowRigParams()
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs)
        SelectRig(1)
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs)
        SelectRig(2)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim freq As Integer
        Rig.SetSimplexMode(freq)
    End Sub


    Private Sub OmnirigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OmnirigToolStripMenuItem.Click
        If OmniRigEngine Is Nothing Then Exit Sub
        OmniRigEngine.DialogVisible = True
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub CloudlogToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloudlogToolStripMenuItem.Click
        CloudlogSettingsForm.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub TransverterOffsetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransverterOffsetToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub fldRigSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fldRigSelection.SelectedIndexChanged
        SelectRig(fldRigSelection.SelectedIndex + 1)
    End Sub
End Class
