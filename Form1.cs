using static System.Runtime.InteropServices.JavaScript.JSType;

namespace VendingMachine
{
    public partial class Form1 : Form
    {

        // this two variables connection with form1 and form2
        public static string send;
        public static int sendNumber;

        public int receivedNumber;

        Button cola, water, chocolate, soda, chips, juice, cracker, energy, biscuit, cake, candy, sandwich;

        // this variables for how many product do you have to assaign
        public static int colaNumber, waterNumber, chocolateNumber, sodaNumber, chipsNumber, juiceNumber, crackerNumber,
            energyNumber, biscuitNumber, cakeNumber, candyNumber, sandwichNumber;
        
        public Form1()
        {
            InitializeComponent();
            MakeTheButtons();
        }

        private void MakeTheButtons()
        {
            // add the cola button 
            cola = new Button();
            cola.Name = "CocaCola";
            cola.Text = "CocaCola(25TL)";
            cola.Size = new Size(120, 30);
            cola.Location = new Point(50, 50);
            cola.BackColor = Color.White;
            colaNumber = 0;
            this.Controls.Add(cola);
            cola.Click += new EventHandler(cola_Click);

            // add the water button
            water = new Button();
            water.Name = "Water";
            water.Text = "Water(5TL)";
            water.Size = new Size(120, 30);
            water.Location = new Point(50, 80);
            water.BackColor = Color.White;
            waterNumber = 0;
            this.Controls.Add(water);
            water.Click += new EventHandler(water_Click);

            // add the chocolate button
            chocolate = new Button();
            chocolate.Name = "Chocolate";
            chocolate.Text = "Chocolate(17TL)";
            chocolate.Size = new Size(120, 30);
            chocolate.Location = new Point(50, 110);
            chocolate.BackColor = Color.White;
            chocolateNumber = 0;
            this.Controls.Add(chocolate);
            chocolate.Click += new EventHandler(chocolate_Click);

            // add the soda button
            soda = new Button();
            soda.Name = "Soda";
            soda.Text = "Soda(20TL)";
            soda.Size = new Size(120, 30);
            soda.Location = new Point(170, 50);
            soda.BackColor = Color.White;
            sodaNumber = 0;
            this.Controls.Add(soda);
            soda.Click += new EventHandler(soda_Click);

            // add the chips button
            chips = new Button();
            chips.Name = "Chips";
            chips.Text = "Chips(23TL)";
            chips.Size = new Size(120, 30);
            chips.Location = new Point(170, 80);
            chips.BackColor = Color.White;
            chipsNumber = 0;
            this.Controls.Add(chips);
            chips.Click += new EventHandler(chips_Click);

            // add the juice button
            juice = new Button();
            juice.Name = "Juice";
            juice.Text = "Juice(15TL)";
            juice.Size = new Size(120, 30);
            juice.Location = new Point(170, 110);
            juice.BackColor = Color.White;
            juiceNumber = 0;
            this.Controls.Add(juice);
            juice.Click += new EventHandler(juice_Click);

            // add the cracker button
            cracker = new Button();
            cracker.Name = "Cracker";
            cracker.Text = "Cracker(18TL)";
            cracker.Size = new Size(120, 30);
            cracker.Location = new Point(290, 50);
            cracker.BackColor = Color.White;
            crackerNumber = 0;
            this.Controls.Add(cracker);
            cracker.Click += new EventHandler(cracker_Click);

            // add the energy button
            energy = new Button();
            energy.Name = "Energy";
            energy.Text = "Energy(35TL)";
            energy.Size = new Size(120, 30);
            energy.Location = new Point(290, 80);
            energy.BackColor = Color.White;
            energyNumber = 0;
            this.Controls.Add(energy);
            energy.Click += new EventHandler(energy_Click);

            // add the biscuit button
            biscuit = new Button();
            biscuit.Name = "Biscuit";
            biscuit.Text = "Biscuit(21TL)";
            biscuit.Size = new Size(120, 30);
            biscuit.Location = new Point(290, 110);
            biscuit.BackColor = Color.White;
            biscuitNumber = 0;
            this.Controls.Add(biscuit);
            biscuit.Click += new EventHandler(biscuit_Click);

            // add the cake button
            cake = new Button();
            cake.Name = "Cake";
            cake.Text = "Cake(8TL)";
            cake.Size = new Size(120, 30);
            cake.Location = new Point(410, 50);
            cake.BackColor = Color.White;
            cakeNumber = 0;
            this.Controls.Add(cake);
            cake.Click += new EventHandler(cake_Click);

            // add the candy button
            candy = new Button();
            candy.Name = "Candy";
            candy.Text = "Candy(13TL)";
            candy.Size = new Size(120, 30);
            candy.Location = new Point(410, 80);
            candy.BackColor = Color.White;
            candyNumber = 0;
            this.Controls.Add(candy);
            candy.Click += new EventHandler(candy_Click);

            // add the sandwich button
            sandwich = new Button();
            sandwich.Name = "Sandwich";
            sandwich.Text = "Sandwich(43TL)";
            sandwich.Size = new Size(120, 30);
            sandwich.Location = new Point(410, 110);
            sandwich.BackColor = Color.White;
            sandwichNumber = 0;
            this.Controls.Add(sandwich);
            sandwich.Click += new EventHandler(sandwich_Click);

            // add the combobox for product addition
            ComboBox productAddition = new ComboBox();
            productAddition.Name = "ProductAddition";
            productAddition.Size = new Size(130, 30);
            productAddition.Location = new Point(550, 60);
            this.Controls.Add(productAddition);
            productAddition.Items.Add("Coca-Cola"); productAddition.Items.Add("Water"); productAddition.Items.Add("Chocolate");
            productAddition.Items.Add("Soda"); productAddition.Items.Add("Chips"); productAddition.Items.Add("Juice");
            productAddition.Items.Add("Cracker"); productAddition.Items.Add("Energy Drink"); productAddition.Items.Add("Biscuit");
            productAddition.Items.Add("Cake"); productAddition.Items.Add("Candy"); productAddition.Items.Add("Sandwich");
            productAddition.IsAccessible = false;

            // add the textbox for to enter how many products will be added
            TextBox productAdditionCount = new TextBox();
            productAdditionCount.Name = "ProductAdditionCount";
            productAdditionCount.Size = new Size(80, 30);
            productAdditionCount.Location = new Point(550, 100);
            this.Controls.Add(productAdditionCount);

            // add the button to add the product
            Button addProduct = new Button();
            addProduct.Name = "AddProduct";
            addProduct.Text = "Add Product";
            addProduct.Size = new Size(100, 30);
            addProduct.Location = new Point(550, 140);
            addProduct.BackColor = Color.White;
            this.Controls.Add(addProduct);
            addProduct.Click += new EventHandler(AddProduct_Click);

        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                // get the product name and count from the combobox and textbox
                ComboBox productAddition = (ComboBox)this.Controls["ProductAddition"];
                TextBox productAdditionCount = (TextBox)this.Controls["ProductAdditionCount"];
                if (productAddition.SelectedItem == null || string.IsNullOrEmpty(productAdditionCount.Text))
                {
                    MessageBox.Show("Please select a product and enter a valid number.");
                    return;
                }
                string productName = productAddition.SelectedItem.ToString();
                int productCount = int.Parse(productAdditionCount.Text);
                // check if the product name is not null
                if (productName == null)
                {
                    MessageBox.Show("Please select a product.");
                    return;
                }
                // add the product to the vending machine

                switch (productName)
                {
                    case "Coca-Cola":
                        colaNumber += productCount;
                        if (colaNumber < 0) colaNumber = 0;
                        break;
                    case "Water":
                        waterNumber += productCount;
                        if (waterNumber < 0) waterNumber = 0;
                        break;
                    case "Chocolate":
                        chocolateNumber += productCount;
                        if (chocolateNumber < 0) chocolateNumber = 0;
                        break;
                    case "Soda":
                        sodaNumber += productCount;
                        if (sodaNumber < 0) sodaNumber = 0;
                        break;
                    case "Chips":
                        chipsNumber += productCount;
                        if (chipsNumber < 0) chipsNumber = 0;
                        break;
                    case "Juice":
                        juiceNumber += productCount;
                        if (juiceNumber < 0) juiceNumber = 0;
                        break;
                    case "Cracker":
                        crackerNumber += productCount;
                        if (crackerNumber < 0) crackerNumber = 0;
                        break;
                    case "Energy":
                        energyNumber += productCount;
                        if (energyNumber < 0) energyNumber = 0;
                        break;
                    case "Biscuit":
                        biscuitNumber += productCount;
                        if (biscuitNumber < 0) biscuitNumber = 0;
                        break;
                    case "Cake":
                        cakeNumber += productCount;
                        if (cakeNumber < 0) cakeNumber = 0;
                        break;
                    case "Candy":
                        candyNumber += productCount;
                        if (candyNumber < 0) candyNumber = 0;
                        break;
                    case "Sandwich":
                        sandwichNumber += productCount;
                        if (sandwichNumber < 0) sandwichNumber = 0;
                        break;
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Please select a product.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select a product and enter a valid number.");

            }
        }

        private void cola_Click(object sender, EventArgs e)
        {
            if (colaNumber < 1)
            {
                MessageBox.Show("There is no Coca-Cola left!");
            }
            else
            {
                send = "CocaCola";
                sendNumber = colaNumber;
                Form2 form2 = new Form2(send, sendNumber, 25);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void water_Click(object sender, EventArgs e)
        {
            if (waterNumber < 1)
            {
                MessageBox.Show("There is no Water left!");
            }
            else
            {
                send = "Water";
                sendNumber = waterNumber;
                Form2 form2 = new Form2(send, sendNumber, 5);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void chocolate_Click(object sender, EventArgs e)
        {
            if (chocolateNumber < 1)
            {
                MessageBox.Show("There is no Chocolate left!");
            }
            else
            {
                send = "Chocolate";
                sendNumber = chocolateNumber;
                Form2 form2 = new Form2(send, sendNumber, 17);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void soda_Click(object sender, EventArgs e)
        {
            if (sodaNumber < 1)
            {
                MessageBox.Show("There is no Soda left!");
            }
            else
            {
                send = "Soda";
                sendNumber = sodaNumber;
                Form2 form2 = new Form2(send, sendNumber, 20);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void chips_Click(object sender, EventArgs e)
        {
            if (chipsNumber < 1)
            {
                MessageBox.Show("There is no Chips left!");
            }
            else
            {
                send = "Chips";
                sendNumber = chipsNumber;
                Form2 form2 = new Form2(send, sendNumber, 23);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void juice_Click(object sender, EventArgs e)
        {
            if (juiceNumber < 1)
            {
                MessageBox.Show("There is no Juice left!");
            }
            else
            {
                send = "Juice";
                sendNumber = juiceNumber;
                Form2 form2 = new Form2(send, sendNumber, 15);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void cracker_Click(object sender, EventArgs e)
        {
            if (crackerNumber < 1)
            {
                MessageBox.Show("There is no Cracker left!");
            }
            else
            {
                send = "Cracker";
                sendNumber = crackerNumber;
                Form2 form2 = new Form2(send, sendNumber, 18);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void energy_Click(object sender, EventArgs e)
        {
            if (energyNumber < 1)
            {
                MessageBox.Show("There is no Energy Drink left!");
            }
            else
            {
                send = "Energy";
                sendNumber = energyNumber;
                Form2 form2 = new Form2(send, sendNumber, 35);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void biscuit_Click(object sender, EventArgs e)
        {
            if (biscuitNumber < 1)
            {
                MessageBox.Show("There is no Biscuit left!");
            }
            else
            {
                send = "Biscuit";
                sendNumber = biscuitNumber;
                Form2 form2 = new Form2(send, sendNumber, 21);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void cake_Click(object sender, EventArgs e)
        {
            if (cakeNumber < 1)
            {
                MessageBox.Show("There is no Cake left!");
            }
            else
            {
                send = "Cake";
                sendNumber = cakeNumber;
                Form2 form2 = new Form2(send, sendNumber, 8);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void candy_Click(object sender, EventArgs e)
        {
            if (candyNumber < 1)
            {
                MessageBox.Show("There is no Candy left!");
            }
            else
            {
                send = "Candy";
                sendNumber = candyNumber;
                Form2 form2 = new Form2(send, sendNumber, 13);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }
        private void sandwich_Click(object sender, EventArgs e)
        {
            if (sandwichNumber < 1)
            {
                MessageBox.Show("There is no Sandwich left!");
            }
            else
            {
                send = "Sandwich";
                sendNumber = sandwichNumber;
                Form2 form2 = new Form2(send, sendNumber, 43);
                form2.FormClosed += (s, args) => this.Show(); // Show Form1 when Form2 is closed
                form2.Show();
                this.Hide();
            }
        }

        public static void UpdateData(int data)
        {
            // update the data in Form1
            switch (send)
            {
                case "CocaCola":
                    colaNumber = data;
                    break;
                case "Water":
                    waterNumber = data;
                    break;
                case "Chocolate":
                    chocolateNumber = data;
                    break;
                case "Soda":
                    sodaNumber = data;
                    break;
                case "Chips":
                    chipsNumber = data;
                    break;
                case "Juice":
                    juiceNumber = data;
                    break;
                case "Cracker":
                    crackerNumber = data;
                    break;
                case "Energy":
                    energyNumber = data;
                    break;
                case "Biscuit":
                    biscuitNumber = data;
                    break;
                case "Cake":
                    cakeNumber = data;
                    break;
                case "Candy":
                    candyNumber = data;
                    break;
                case "Sandwich":
                    sandwichNumber = data;
                    break;
            }
        }
    }

}
