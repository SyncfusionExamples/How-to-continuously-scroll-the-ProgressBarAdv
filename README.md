# How to continuously scroll the ProgressBarAdv

The ProgressBarAdv can be scroll by handling Timer. The value for ProgressBarAdv can be set in timer_Tick event. In that event increasing the value will scroll the ProgressBarAdv continuously .The value can be assigned as shown in the below code.

Enable the timer in the button_Click event.

```C#
private void button1_Click(object sender, EventArgs e)
{
this.timer1.Enabled = true;
}
```

```VB
Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
Me.timer1.Enabled = True
End Sub
```

Add the below given code in the timer_Tick event

```C#
private void timer1_Tick(object sender, EventArgs e)
{
if (this.progressBarAdv1.Value < 100)

this.progressBarAdv1.Value++;

else

this.progressBarAdv1.Value = 0;
}
```

```VB
Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
If Me.progressBarAdv1.Value < 100 Then

Me.progressBarAdv1.Value += 1

Else

Me.progressBarAdv1.Value = 0
End If
End Sub
```

Output:

![ProgressBarAdv_Scroll](ProgressBarAdv_Scroll.png)
