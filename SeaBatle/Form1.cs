namespace SeaBatle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Model = new model();
            Model.PlayerShips[0, 0] = CoordStatus.Ship;
            Model.PlayerShips[5, 2] = CoordStatus.Ship;
            Model.PlayerShips[5, 3] = CoordStatus.Ship;
            Model.PlayerShips[5, 1] = CoordStatus.Ship;
            Model.PlayerShips[7, 3] = CoordStatus.Ship;
            for (int i = 0; i < 10; i++)
                dataGridView1.Rows.Add(row);
            dataGridView1.ClearSelection();
        }
        model Model;
        string[] row = { "", "", "", "", "", "", "", "", "", "" };
        int x4 = 1;
        int x3 = 2;
        int x2 = 3;
        int x1 = 4;
        private void button21_Click(object sender, EventArgs e)
        {

            Model.LastShot = Model.Shot(textBox1.Text);
            int x = int.Parse(textBox1.Text.Substring(0, 1));
            int y = int.Parse(textBox1.Text.Substring(1));
            switch (Model.LastShot)
            {
                case ShotStatus.Miss:
                    Model.EnemyShips[x, y] = CoordStatus.Shot; break;
                case ShotStatus.Wounded:
                    Model.EnemyShips[x, y] = CoordStatus.Got; break;
                case ShotStatus.Kill:
                    Model.EnemyShips[x, y] = CoordStatus.Got; break;
            }
            //Model.LastShotCoord = textBox1.Text;
            if (Model.LastShot == ShotStatus.Wounded)
            {
                Model.LastShotCoord = textBox1.Text;
                Model.WoundedStatus = true;

            }
            MessageBox.Show(Model.LastShot.ToString());
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string s;
            int x, y;
            do
            {
                s = Model.ShotGen();
                x = int.Parse(s.Substring(0, 1));
                y = int.Parse(s.Substring(1));
            }
            while (Model.EnemyShips[x, y] != CoordStatus.None);
            textBox1.Text = s;

        }

        private void button134_Click(object sender, EventArgs e)
        {
            //var b =
            /*for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                {
                    string name = "b" + x.ToString() + y.ToString();
                    var b = this.Controls.Find(name, true);

                    if (b.Count() > 0)
                    {
                        var btn = b[0];
                        switch (Model.PlayerShips[x, y])
                        {
                            case CoordStatus.Ship:
                                btn.Text = "x";
                                break;
                            case CoordStatus.None: btn.Text = ""; break;
                        }

                    }
                } */
            for (int x = 0; x < 10; x++)
                for (int y = 0; y < 10; y++)
                {

                    switch (Model.PlayerShips[x, y])
                    {
                        case CoordStatus.Ship:
                            dataGridView1[x, y].Value = "x";
                            break;
                        case CoordStatus.None:
                            dataGridView1[x, y].Value = "";
                            break;
                    }


                }
        }

        private void button133_Click(object sender, EventArgs e)
        {
            int cnt = dataGridView1.SelectedCells.Count;
            if (cnt > 0)
            {
                if (checkBox2.Checked)
                {
                    int a, b;
                    a = dataGridView1.SelectedCells[0].RowIndex;
                    b = dataGridView1.SelectedCells[0].ColumnIndex;
                    if (dataGridView1.Rows[a].Cells[b].Value.ToString() == "") return;
                }
                if (cnt == 1)
                    if (!checkBox2.Checked)
                    {
                        if (x1 == 0) return;
                        x1--;
                    }
                    else x1++;
                if (cnt == 2)
                    if (!checkBox2.Checked)
                    {
                        if (x2 == 0) return;
                        x2--;
                    }
                    else x2++;
                if (cnt == 3)
                    if (!checkBox2.Checked)
                    {
                        if (x3 == 0) return;
                        x3--;
                    }
                    else x3++;
                if (cnt == 4)
                    if (!checkBox2.Checked)
                    {
                        if (x4 == 0) return;
                        x4--;
                    }
                    else x4++;

                for (int i = 0; i < dataGridView1.SelectedCells.Count; i++)
                {
                    int x = dataGridView1.SelectedCells[i].ColumnIndex;
                    int y = dataGridView1.SelectedCells[i].RowIndex;
                    CoordStatus coordStatus;
                    if (!checkBox2.Checked) coordStatus = CoordStatus.Ship;
                    else coordStatus = CoordStatus.None;
                    Model.PlayerShips[x, y] = coordStatus;
                }
                dataGridView1.ClearSelection();
            }
            //else
            //{
            //    Direction direction;
            //    ShipType shipType = ShipType.x1;
            //    if (checkBox1.Checked) direction = Direction.Vertical; else direction = Direction.Horizontal;
            //    if (radioButton1.Checked) shipType = ShipType.x1;
            //    if (radioButton2.Checked) shipType = ShipType.x2;
            //    if (radioButton3.Checked) shipType = ShipType.x3;
            //    if (radioButton4.Checked) shipType = ShipType.x4;
            //    Model.AddDelShip(textBox1.Text, shipType, direction, checkBox2.Checked);
            //}
            button134_Click(sender, e);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int y = dataGridView1.SelectedCells[0].RowIndex;
            int x = dataGridView1.SelectedCells[0].ColumnIndex;
            textBox1.Text = x.ToString() + y.ToString();
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { button133.Text = "Удалить"; }
            else { button133.Text = "Поставить"; }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int cnt = dataGridView1.SelectedCells.Count;
            textBox1.Text = cnt.ToString();
            if (cnt > 4)
            {
                MessageBox.Show("Превышено количество клеток!");
                int x = dataGridView1.SelectedCells[cnt - 1].ColumnIndex;
                int y = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.Rows[y].Cells[x].Selected = false;
                dataGridView1.ClearSelection();
            }
            //if (cnt==4) dataGridView1.SelectedCells

        }
    }
}