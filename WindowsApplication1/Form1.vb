Public Class Form1

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim i As Integer

        For i = 0 To AxVideoCap1.GetDeviceCount - 1
            cbovideodevice.Items.Add(AxVideoCap1.GetDeviceName(i))
        Next

        If cbovideodevice.Items.Count > 0 Then
            cbovideodevice.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbovideodevice_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cbovideodevice.SelectedIndexChanged
    
        AxVideoCap1.RefreshVideoDevice(cbovideodevice.SelectedIndex)
        AddStillPinVideoFormat()
    End Sub

    Private Sub AddStillPinVideoFormat()
        Dim i As Integer
        Dim strStillPinName As String

        cbostillpinformat.Items.Clear()
        For i = 0 To AxVideoCap1.StillPinVideoFormats.Count - 1
            strStillPinName = AxVideoCap1.StillPinVideoFormats.FindVideoFormatName(i)
            cbostillpinformat.Items.Add(strStillPinName)
        Next

        If cbostillpinformat.Items.Count > 0 Then

            cbostillpinformat.SelectedIndex = 0
        End If


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        AxVideoCap1.Device = cbovideodevice.SelectedIndex
        AxVideoCap1.StillPinVideoFormat = cbostillpinformat.SelectedIndex
        AxVideoCap1.Start()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        SaveFileDialog1.Filter = "JPEG file (*.jpg)|*.jpg||"
        SaveFileDialog1.DefaultExt = "jpg"
        SaveFileDialog1.ShowDialog()
        AxVideoCap1.SnapShotJPEG(SaveFileDialog1.FileName, 99)
    End Sub
End Class