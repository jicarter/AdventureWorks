﻿Class MainWindow
    Private Sub Exit_Click(sender As Object, e As RoutedEventArgs)
        Me.Close()
    End Sub

    Private Sub ProductDetail_Click(sender As Object, e As RoutedEventArgs)
        contentArea.Children.Clear()
        contentArea.Children.Add(New ProductDetailControl())
    End Sub
End Class
