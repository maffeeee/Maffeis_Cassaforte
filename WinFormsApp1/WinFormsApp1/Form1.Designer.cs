namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            codiceutente = new Label();
            insutente = new TextBox();
            insblocco = new TextBox();
            label1 = new Label();
            cassaforte = new Label();
            invia = new Button();
            invias = new Button();
            stato = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(445, 89);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 1;
            label2.Text = "codice sblocco";
            // 
            // codiceutente
            // 
            codiceutente.AutoSize = true;
            codiceutente.Location = new Point(149, 89);
            codiceutente.Name = "codiceutente";
            codiceutente.Size = new Size(90, 15);
            codiceutente.TabIndex = 2;
            codiceutente.Text = "CODICEUTENTE";
            // 
            // insutente
            // 
            insutente.Location = new Point(139, 135);
            insutente.Name = "insutente";
            insutente.Size = new Size(100, 23);
            insutente.TabIndex = 4;
            // 
            // insblocco
            // 
            insblocco.Location = new Point(431, 135);
            insblocco.Name = "insblocco";
            insblocco.Size = new Size(100, 23);
            insblocco.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 258);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 6;
            label1.Text = "stato";
            // 
            // cassaforte
            // 
            cassaforte.AutoSize = true;
            cassaforte.Location = new Point(278, 289);
            cassaforte.Name = "cassaforte";
            cassaforte.Size = new Size(76, 15);
            cassaforte.TabIndex = 7;
            cassaforte.Text = "CASSAFORTE";
            // 
            // invia
            // 
            invia.Location = new Point(264, 134);
            invia.Name = "invia";
            invia.Size = new Size(75, 23);
            invia.TabIndex = 8;
            invia.Text = "invia";
            invia.UseVisualStyleBackColor = true;
            // 
            // invias
            // 
            invias.Location = new Point(591, 135);
            invias.Name = "invias";
            invias.Size = new Size(75, 23);
            invias.TabIndex = 9;
            invias.Text = "invia";
            invias.UseVisualStyleBackColor = true;
            // 
            // stato
            // 
            stato.AutoSize = true;
            stato.Location = new Point(317, 258);
            stato.Name = "stato";
            stato.Size = new Size(38, 15);
            stato.TabIndex = 10;
            stato.Text = "label5";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stato);
            Controls.Add(invias);
            Controls.Add(invia);
            Controls.Add(cassaforte);
            Controls.Add(label1);
            Controls.Add(insblocco);
            Controls.Add(insutente);
            Controls.Add(codiceutente);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label codiceutente;
        private TextBox insutente;
        private TextBox insblocco;
        private Label label1;
        private Label cassaforte;
        private Button invia;
        private Button invias;
        private Label stato;
    }
}
