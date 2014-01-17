private void button4_Click(object sender, EventArgs e)
        {
            int w = 0;
            int szukaj;
            szukaj = Convert.ToInt32(StanT.Text);
            int twr;
            if (TowaryTabela.Rows.Count > 0)
            {
                for (int i = 0; i < TowaryTabela.Rows.Count; i++)
                {
                    for (int j = 7; j < 8; j++)
                    {
                        twr = Convert.ToInt32(TowaryTabela.Rows[i].Cells[j].Value);
                        if ( twr <= szukaj) 
                        {
                            TowaryTabela.Rows[i].Selected = true;
                            w = w + 1;
                            break;
                        }
                    }

                }
            }
            label1.Text = w.ToString();
            if (w == 0)
            {
                MessageBox.Show("Wszystkie towary posiadaj¹ stan wiekszy od podanego minimum.","Informacja");
            }

        }
