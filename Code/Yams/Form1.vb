Public Class Yams
    Dim nombre_aleatoire As Int32
    Dim tour As Int32 = 1
    Dim tableau(4) As Int32
    Dim valeur_total1 As Int32 = 0
    Dim valeur_total2 As Int32 = 0
    Dim valeur_total3 As Int32 = 0
    Dim valeur_total4 As Int32 = 0
    Dim valeur_total5 As Int32 = 0
    Dim valeur_total6 As Int32 = 0
    Dim jouer As Boolean = False
    Dim attendre As Boolean = False



    Private Sub zero()
        valeur_total1 = 0
        valeur_total2 = 0
        valeur_total3 = 0
        valeur_total4 = 0
        valeur_total5 = 0
        valeur_total6 = 0

    End Sub
    Private Sub start()
        soustotal()
        attendre = False
        txtDé1.Text = ""
        txtDé2.Text = ""
        txtDé3.Text = ""
        txtDé4.Text = ""
        txtDé5.Text = ""
        zero()
        jouer = False
        clear()

        tour = 1
        visualisation()

    End Sub
    Private Sub compteur()
        zero()
        For Each number In tableau
            If number = 1 Then
                valeur_total1 = valeur_total1 + 1
            End If
            If number = 2 Then
                valeur_total2 = valeur_total2 + 2
            End If
            If number = 3 Then
                valeur_total3 = valeur_total3 + 3
            End If
            If number = 4 Then
                valeur_total4 = valeur_total4 + 4
            End If
            If number = 5 Then
                valeur_total5 = valeur_total5 + 5
            End If
            If number = 6 Then
                valeur_total6 = valeur_total6 + 6
            End If
        Next number



    End Sub
    Private Sub affichage()
        txtDé1.Text = tableau(0)
        txtDé2.Text = tableau(1)
        txtDé3.Text = tableau(2)
        txtDé4.Text = tableau(3)
        txtDé5.Text = tableau(4)
    End Sub
    Private Sub génération_dé()
        Randomize()
        nombre_aleatoire = Int(6 * Rnd()) + 1
    End Sub
    Private Sub clear()
        CheckDé1.Checked = False
        CheckDé2.Checked = False
        CheckDé3.Checked = False
        CheckDé4.Checked = False
        CheckDé5.Checked = False
    End Sub
    Private Sub visualisation()
        If (tour = 1) Then
            cmdLancer1.Visible = True
            cmdLancer2.Visible = False
            cmdLancer3.Visible = False
            CheckDé1.Visible = False
            CheckDé2.Visible = False
            CheckDé3.Visible = False
            CheckDé4.Visible = False
            CheckDé5.Visible = False
        End If
        If (tour = 2) Then
            cmdLancer1.Visible = False
            cmdLancer2.Visible = True
            cmdLancer3.Visible = False
            CheckDé1.Visible = True
            CheckDé2.Visible = True
            CheckDé3.Visible = True
            CheckDé4.Visible = True
            CheckDé5.Visible = True
        End If
        If (tour = 3) Then
            cmdLancer1.Visible = False
            cmdLancer2.Visible = False
            cmdLancer3.Visible = True
            CheckDé1.Visible = True
            CheckDé2.Visible = True
            CheckDé3.Visible = True
            CheckDé4.Visible = True
            CheckDé5.Visible = True
        End If
    End Sub


    Private Sub cmdLancer1_Click(sender As Object, e As EventArgs) Handles cmdLancer1.Click
        If (tour = 1) Then
            tour += 1
            attendre = True
            génération_dé()
            tableau(0) = nombre_aleatoire
            génération_dé()
            tableau(1) = nombre_aleatoire
            génération_dé()
            tableau(2) = nombre_aleatoire
            génération_dé()
            tableau(3) = nombre_aleatoire
            génération_dé()
            tableau(4) = nombre_aleatoire
            compteur()

            affichage()
            clear()
            visualisation()
            jouer = False

        End If

    End Sub
    Private Sub cmdLancer2_Click(sender As Object, e As EventArgs) Handles cmdLancer2.Click
        If (tour = 2) Then
            tour += 1
            If (CheckDé1.Checked = True) Then
                génération_dé()
                tableau(0) = nombre_aleatoire
            End If

            If (CheckDé2.Checked = True) Then
                génération_dé()
                tableau(1) = nombre_aleatoire
            End If

            If (CheckDé3.Checked = True) Then
                génération_dé()
                tableau(2) = nombre_aleatoire
            End If

            If (CheckDé4.Checked = True) Then
                génération_dé()
                tableau(3) = nombre_aleatoire
            End If

            If (CheckDé5.Checked = True) Then
                génération_dé()
                tableau(4) = nombre_aleatoire
            End If
            compteur()

            affichage()
            clear()
            visualisation()
            jouer = False

        End If

    End Sub
    Private Sub cmdLancer3_Click(sender As Object, e As EventArgs) Handles cmdLancer3.Click
        If (tour = 3) Then
            tour += 1
            If (CheckDé1.Checked = True) Then
                génération_dé()
                tableau(0) = nombre_aleatoire
            End If

            If (CheckDé2.Checked = True) Then
                génération_dé()
                tableau(1) = nombre_aleatoire
            End If

            If (CheckDé3.Checked = True) Then
                génération_dé()
                tableau(2) = nombre_aleatoire
            End If

            If (CheckDé4.Checked = True) Then
                génération_dé()
                tableau(3) = nombre_aleatoire
            End If

            If (CheckDé5.Checked = True) Then
                génération_dé()
                tableau(4) = nombre_aleatoire

            End If
            compteur()

            affichage()
            clear()
            visualisation()
            jouer = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clear()
        totaldeux()
        soustotal()
        total1()
        bonus()

    End Sub
    Private Sub cmdQuitter_Click(sender As Object, e As EventArgs) Handles cmdQuitter.Click
        Close()
    End Sub



    Private Sub cmdStart_Click(sender As Object, e As EventArgs) Handles cmdStart.Click
        cmdStart.Visible = False
        cmdRègle.Visible = False
        cmdQuitter1.Visible = False
        cmdLancer1.Visible = True
        cmdLancer2.Visible = False
        cmdLancer3.Visible = False
        CheckDé1.Visible = False
        CheckDé2.Visible = False
        CheckDé3.Visible = False
        CheckDé4.Visible = False
        CheckDé5.Visible = False
        txtDé1.Visible = True
        txtDé2.Visible = True
        txtDé3.Visible = True
        txtDé4.Visible = True
        txtDé5.Visible = True
        txtTotal1.Visible = True
        txtTotal2.Visible = True
        txtTotal3.Visible = True
        txtTotal4.Visible = True
        txtTotal5.Visible = True
        txtTotal6.Visible = True
        txtCombinaisons.Visible = True
        txtsoustotal.Visible = True
        txtbonus.Visible = True
        txttotalun.Visible = True
        txtmax.Visible = True
        txtmin.Visible = True
        txttotaldeux.Visible = True
        txtCarré.Visible = True
        txtFull.Visible = True
        txtSuite.Visible = True
        txtYam.Visible = True
        txttotaltrois.Visible = True
        txttotal.Visible = True
        txtJ1.Visible = True
        txtJ2.Visible = True
        txtJ3.Visible = True
        txtJ4.Visible = True
        txtJ1T1.Visible = True
        txtJ2T1.Visible = True
        txtJ3T1.Visible = True
        txtJ4T1.Visible = True

        txtJ1T2.Visible = True
        txtJ2T2.Visible = True
        txtJ3T2.Visible = True
        txtJ4T2.Visible = True

        txtJ1T3.Visible = True
        txtJ2T3.Visible = True
        txtJ3T3.Visible = True
        txtJ4T3.Visible = True

        txtJ1T4.Visible = True
        txtJ2T4.Visible = True
        txtJ3T4.Visible = True
        txtJ4T4.Visible = True

        txtJ1T5.Visible = True
        txtJ2T5.Visible = True
        txtJ3T5.Visible = True
        txtJ4T5.Visible = True

        txtJ1T6.Visible = True
        txtJ2T6.Visible = True
        txtJ3T6.Visible = True
        txtJ4T6.Visible = True

        txtJ1soustotal.Visible = True
        txtJ1Bonus.Visible = True
        txtJ1Totalun.Visible = True

        txtJ2soustotal.Visible = True
        txtJ2Bonus.Visible = True
        txtJ2Totalun.Visible = True

        txtJ3soustotal.Visible = True
        txtJ3Bonus.Visible = True
        txtJ3Totalun.Visible = True

        txtJ4soustotal.Visible = True
        txtJ4Bonus.Visible = True
        txtJ4Totalun.Visible = True

        txtJ1max.Visible = True
        txtJ1min.Visible = True
        txtJ1totaldeux.Visible = True

        txtJ2max.Visible = True
        txtJ2min.Visible = True
        txtJ2totaldeux.Visible = True

        txtJ3max.Visible = True
        txtJ3min.Visible = True
        txtJ3totaldeux.Visible = True

        txtJ4max.Visible = True
        txtJ4min.Visible = True
        txtJ4totaldeux.Visible = True

        txtJ1Carré.Visible = True
        txtJ1Full.Visible = True
        txtJ1Suite.Visible = True
        txtJ1Yam.Visible = True
        txtJ1Totaltrois.Visible = True
        txtJ1Total.Visible = True

        txtJ2Carré.Visible = True
        txtJ2Full.Visible = True
        txtJ2Suite.Visible = True
        txtJ2Yam.Visible = True
        txtJ2Totaltrois.Visible = True
        txtJ2Total.Visible = True

        txtJ3Carré.Visible = True
        txtJ3Full.Visible = True
        txtJ3Suite.Visible = True
        txtJ3Yam.Visible = True
        txtJ3Totaltrois.Visible = True
        txtJ3Total.Visible = True

        txtJ4Carré.Visible = True
        txtJ4Full.Visible = True
        txtJ4Suite.Visible = True
        txtJ4Yam.Visible = True
        txtJ4Totaltrois.Visible = True
        txtJ4Total.Visible = True





    End Sub
    Private Sub cmdRègle_Click(sender As Object, e As EventArgs) Handles cmdRègle.Click

    End Sub
    Private Sub cmdQuitter1_Click(sender As Object, e As EventArgs) Handles cmdQuitter1.Click
        Close()
    End Sub





    Private Sub txtJ1T1_Click(sender As Object, e As EventArgs) Handles txtJ1T1.Click
        If (valeur_total1 >= 1) And (txtJ1T1.Enabled = True) And (jouer = False) And (attendre = True) Then
            txtJ1T1.Text = valeur_total1
            txtJ1T1.Enabled = False
            jouer = True
            start()

        ElseIf (jouer = False) And (attendre = True) Then
            txtJ1T1.Text = "0"
            txtJ1T1.Enabled = False
            jouer = True
            start()

        End If
    End Sub

    Private Sub txtJ1T2_Click(sender As Object, e As EventArgs) Handles txtJ1T2.Click
        If (valeur_total2 >= 2) And (txtJ1T2.Enabled = True) And (jouer = False) And (attendre = True) Then
            txtJ1T2.Text = valeur_total2
            txtJ1T2.Enabled = False
            jouer = True
            start()

        ElseIf (jouer = False) And (attendre = True) Then
            txtJ1T2.Text = "0"
            txtJ1T2.Enabled = False
            jouer = True
            start()

        End If
    End Sub

    Private Sub txtJ1T3_Click(sender As Object, e As EventArgs) Handles txtJ1T3.Click
        If (valeur_total3 >= 3) And (txtJ1T3.Enabled = True) And (jouer = False) And (attendre = True) Then
            txtJ1T3.Text = valeur_total3
            txtJ1T3.Enabled = False
            jouer = True
            start()

        ElseIf (jouer = False) And (attendre = True) Then
            txtJ1T3.Text = "0"
            txtJ1T3.Enabled = False
            jouer = True
            start()

        End If
    End Sub

    Private Sub txtJ1T4_Click(sender As Object, e As EventArgs) Handles txtJ1T4.Click
        If (valeur_total4 >= 4) And (txtJ1T4.Enabled = True) And (jouer = False) And (attendre = True) Then
            txtJ1T4.Text = valeur_total4
            txtJ1T4.Enabled = False
            jouer = True
            start()

        ElseIf (jouer = False) And (attendre = True) Then
            txtJ1T4.Text = "0"
            txtJ1T4.Enabled = False
            jouer = True
            start()

        End If
    End Sub

    Private Sub txtJ1T5_Click(sender As Object, e As EventArgs) Handles txtJ1T5.Click
        If (valeur_total5 >= 5) And (txtJ1T5.Enabled = True) And (jouer = False) And (attendre = True) Then
            txtJ1T5.Text = valeur_total5
            txtJ1T5.Enabled = False
            jouer = True
            start()
        ElseIf (jouer = False) And (attendre = True) Then
            txtJ1T5.Text = "0"
            txtJ1T5.Enabled = False
            jouer = True
            start()

        End If
    End Sub

    Private Sub txtJ1T6_Click(sender As Object, e As EventArgs) Handles txtJ1T6.Click
        If (valeur_total6 >= 6) And (txtJ1T6.Enabled = True) And (jouer = False) And (attendre = True) Then
            txtJ1T6.Text = valeur_total6
            txtJ1T6.Enabled = False
            jouer = True
            start()

        ElseIf (jouer = False) And (attendre = True) Then
            txtJ1T6.Text = "0"
            txtJ1T6.Enabled = False
            jouer = True
            start()
        End If
    End Sub

    Private Sub soustotal()
        If (txtJ1T1.Enabled = False) Or (txtJ1T2.Enabled = False) Or (txtJ1T3.Enabled = False) Or (txtJ1T4.Enabled = False) Or (txtJ1T5.Enabled = False) Or (txtJ1T6.Enabled = False) Then
            txtJ1soustotal.Text = Val(txtJ1T1.Text) + Val(txtJ1T2.Text) + Val(txtJ1T3.Text) + Val(txtJ1T4.Text) + Val(txtJ1T5.Text) + Val(txtJ1T6.Text)
        End If
        If (txtJ2T1.Enabled = False) Or (txtJ2T2.Enabled = False) Or (txtJ2T3.Enabled = False) Or (txtJ2T4.Enabled = False) Or (txtJ2T5.Enabled = False) Or (txtJ2T6.Enabled = False) Then
            txtJ2soustotal.Text = Val(txtJ2T1.Text) + Val(txtJ2T2.Text) + Val(txtJ2T3.Text) + Val(txtJ2T4.Text) + Val(txtJ2T5.Text) + Val(txtJ2T6.Text)
        End If
        If (txtJ3T1.Enabled = False) Or (txtJ3T2.Enabled = False) Or (txtJ3T3.Enabled = False) Or (txtJ3T4.Enabled = False) Or (txtJ3T5.Enabled = False) Or (txtJ3T6.Enabled = False) Then
            txtJ3soustotal.Text = Val(txtJ3T1.Text) + Val(txtJ3T2.Text) + Val(txtJ3T3.Text) + Val(txtJ3T4.Text) + Val(txtJ3T5.Text) + Val(txtJ3T6.Text)
        End If
        If (txtJ4T1.Enabled = False) Or (txtJ4T2.Enabled = False) Or (txtJ4T3.Enabled = False) Or (txtJ4T4.Enabled = False) Or (txtJ4T5.Enabled = False) Or (txtJ1T6.Enabled = False) Then
            txtJ4soustotal.Text = Val(txtJ4T1.Text) + Val(txtJ4T2.Text) + Val(txtJ4T3.Text) + Val(txtJ4T4.Text) + Val(txtJ4T5.Text) + Val(txtJ4T6.Text)
        End If
        bonus()
        total1()
    End Sub

    Private Sub bonus()
        If (Val(txtJ1soustotal.Text) >= 63) Then
            txtJ1Bonus.Text = "35"
        End If
        If (Val(txtJ2soustotal.Text) >= 63) Then
            txtJ2Bonus.Text = "35"
        End If
        If (Val(txtJ3soustotal.Text) >= 63) Then
            txtJ3Bonus.Text = "35"
        End If
        If (Val(txtJ4soustotal.Text) >= 63) Then
            txtJ4Bonus.Text = "35"
        End If

    End Sub

    Private Sub total1()
        If (Val(txtJ1soustotal.Text) > 0) Then
            txtJ1Totalun.Text = Val(txtJ1soustotal.Text) + Val(txtJ1Bonus.Text)
        End If

        If (Val(txtJ2soustotal.Text) > 0) Then
            txtJ2Totalun.Text = Val(txtJ2soustotal.Text) + Val(txtJ2Bonus.Text)
        End If

        If (Val(txtJ3soustotal.Text) > 0) Then
            txtJ3Totalun.Text = Val(txtJ3soustotal.Text) + Val(txtJ3Bonus.Text)
        End If

        If (Val(txtJ4soustotal.Text) > 0) Then
            txtJ4Totalun.Text = Val(txtJ4soustotal.Text) + Val(txtJ4Bonus.Text)
        End If
    End Sub

    Private Sub txtJ1max_click(sender As Object, e As EventArgs) Handles txtJ1max.Click
        If (txtJ1max.Enabled = True) And (attendre = True) Then
            txtJ1max.Text = valeur_total1 + valeur_total2 + valeur_total3 + valeur_total4 + valeur_total5 + valeur_total6
            txtJ1max.Enabled = False
            jouer = True
            start()
            totaldeux()
        End If


    End Sub

    Private Sub txtJ1min_Click(sender As Object, e As EventArgs) Handles txtJ1min.Click
        If (txtJ1min.Enabled = True) And (attendre = True) Then
            txtJ1min.Text = valeur_total1 + valeur_total2 + valeur_total3 + valeur_total4 + valeur_total5 + valeur_total6
            txtJ1min.Enabled = False
            jouer = True
            start()
            totaldeux()
        End If
    End Sub

    Private Sub totaldeux()
        If (txtJ1max.Enabled = False) And (txtJ1min.Enabled = False) Then
            txtJ1totaldeux.Text = Val(txtJ1max.Text) - Val(txtJ1min.Text)
        End If

        If (txtJ2max.Enabled = False) And (txtJ2min.Enabled = False) Then
            txtJ2totaldeux.Text = Val(txtJ2max.Text) - Val(txtJ2min.Text)
        End If

        If (txtJ3max.Enabled = False) And (txtJ3min.Enabled = False) Then
            txtJ3totaldeux.Text = Val(txtJ3max.Text) - Val(txtJ3min.Text)
        End If

        If (txtJ4max.Enabled = False) And (txtJ4min.Enabled = False) Then
            txtJ4totaldeux.Text = Val(txtJ4max.Text) - Val(txtJ4min.Text)
        End If
    End Sub

    Private Sub txtJ1Carré_click(sender As Object, e As EventArgs) Handles txtJ1Carré.Click
        If ((valeur_total1 = 4) Or (valeur_total2 = 8) Or (valeur_total3 = 12) Or (valeur_total4 = 16) Or (valeur_total5 = 20) Or (valeur_total6 = 24)) And (attendre = True) Then
            txtJ1Carré.Text = valeur_total1 + valeur_total2 + valeur_total3 + valeur_total4 + valeur_total5 + valeur_total6
            txtJ1Carré.Enabled = False
            jouer = True
            start()
            total3()
        End If
    End Sub

    Private Sub txtJ1Full_Click(sender As Object, e As EventArgs) Handles txtJ1Full.Click
        If ((valeur_total1 = 3) Or (valeur_total2 = 6) Or (valeur_total3 = 9) Or (valeur_total4 = 12) Or (valeur_total5 = 15) Or (valeur_total6 = 18)) And ((valeur_total1 = 2) Or (valeur_total2 = 4) Or (valeur_total3 = 6) Or (valeur_total4 = 8) Or (valeur_total5 = 10) Or (valeur_total6 = 12)) And (attendre = True) Then
            txtJ1Full.Text = 25
            txtJ1Full.Enabled = False
            jouer = True
            start()
            total3()
        End If
    End Sub

    Private Sub txtJ1Suite_Click(sender As Object, e As EventArgs) Handles txtJ1Suite.Click
        If (((valeur_total1 = 1) And (valeur_total2 = 2) And (valeur_total3 = 3) And (valeur_total4 = 4) And (valeur_total5 = 5)) Or ((valeur_total2 = 2) And (valeur_total3 = 3) And (valeur_total4 = 4) And (valeur_total5 = 5) And (valeur_total6 = 6))) And (attendre = True) Then
            txtJ1Suite.Text = 40
            txtJ1Suite.Enabled = False
            jouer = True
            start()
            total3()
        End If
    End Sub

    Private Sub txtJ1Yam_Click(sender As Object, e As EventArgs) Handles txtJ1Yam.Click
        If ((valeur_total1 = 5) Or (valeur_total2 = 10) Or (valeur_total3 = 15) Or (valeur_total4 = 20) Or (valeur_total5 = 25) Or (valeur_total6 = 30)) And (attendre = True) Then
            txtJ1Yam.Text = 50
            txtJ1Yam.Enabled = False
            jouer = True
            start()
            total3()
        End If
    End Sub

    Private Sub total3()
        If (txtJ1Carré.Enabled = False) Or (txtJ1Full.Enabled = False) Or (txtJ1Suite.Enabled = False) Or (txtJ1Yam.Enabled = False) Then
            txtJ1Totaltrois.Text = Val(txtJ1Carré.Text) + Val(txtJ1Full.Text) + Val(txtJ1Suite.Text) + Val(txtJ1Yam.Text)
            total()
        End If
        If (txtJ2Carré.Enabled = False) Or (txtJ2Full.Enabled = False) Or (txtJ2Suite.Enabled = False) Or (txtJ2Yam.Enabled = False) Then
            txtJ2Totaltrois.Text = Val(txtJ2Carré.Text) + Val(txtJ2Full.Text) + Val(txtJ2Suite.Text) + Val(txtJ2Yam.Text)
            total()
        End If
        If (txtJ3Carré.Enabled = False) Or (txtJ3Full.Enabled = False) Or (txtJ3Suite.Enabled = False) Or (txtJ3Yam.Enabled = False) Then
            txtJ3Totaltrois.Text = Val(txtJ3Carré.Text) + Val(txtJ3Full.Text) + Val(txtJ3Suite.Text) + Val(txtJ3Yam.Text)
            total()
        End If
        If (txtJ4Carré.Enabled = False) Or (txtJ4Full.Enabled = False) Or (txtJ4Suite.Enabled = False) Or (txtJ4Yam.Enabled = False) Then
            txtJ4Totaltrois.Text = Val(txtJ4Carré.Text) + Val(txtJ4Full.Text) + Val(txtJ4Suite.Text) + Val(txtJ4Yam.Text)
            total()
        End If
    End Sub

    Private Sub total()
        txtJ1Total.Text = Val(txtJ1Totalun.Text) + Val(txtJ1totaldeux.Text) + Val(txtJ1Totaltrois.Text)
        txtJ2Total.Text = Val(txtJ2Totalun.Text) + Val(txtJ2totaldeux.Text) + Val(txtJ2Totaltrois.Text)
        txtJ3Total.Text = Val(txtJ3Totalun.Text) + Val(txtJ3totaldeux.Text) + Val(txtJ3Totaltrois.Text)
        txtJ4Total.Text = Val(txtJ4Totalun.Text) + Val(txtJ4totaldeux.Text) + Val(txtJ4Totaltrois.Text)
    End Sub
End Class
