﻿namespace Lojinha
{
    partial class TelaPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.exitButton = new System.Windows.Forms.Button();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarStatusDePedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarFormaDePagamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaParaEsteFormulárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.addProductButton = new System.Windows.Forms.Button();
            this.viewStorageButton = new System.Windows.Forms.Button();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.viewOrdersButton = new System.Windows.Forms.Button();
            this.viewClientsButton = new System.Windows.Forms.Button();
            this.createUserButton = new System.Windows.Forms.Button();
            this.addPaymentButton = new System.Windows.Forms.Button();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.helpButton = new System.Windows.Forms.Button();
            this.helpBalloon2 = new System.Windows.Forms.PictureBox();
            this.retroGirlImage = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.maximizeButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.closeButton = new System.Windows.Forms.Button();
            this.normalSizeButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBalloon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retroGirlImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.ForeColor = System.Drawing.Color.Black;
            this.exitButton.Image = global::Lojinha.Properties.Resources.closeBtn;
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarUsuárioToolStripMenuItem,
            this.alterarSenhaToolStripMenuItem});
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            resources.ApplyResources(this.produtosToolStripMenuItem, "produtosToolStripMenuItem");
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // cadastrarUsuárioToolStripMenuItem
            // 
            this.cadastrarUsuárioToolStripMenuItem.Name = "cadastrarUsuárioToolStripMenuItem";
            resources.ApplyResources(this.cadastrarUsuárioToolStripMenuItem, "cadastrarUsuárioToolStripMenuItem");
            this.cadastrarUsuárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarUsuárioToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            resources.ApplyResources(this.alterarSenhaToolStripMenuItem, "alterarSenhaToolStripMenuItem");
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarProdutoToolStripMenuItem,
            this.visualizarEstoqueToolStripMenuItem,
            this.cadastrarCategoriaToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            resources.ApplyResources(this.clientesToolStripMenuItem, "clientesToolStripMenuItem");
            // 
            // adicionarProdutoToolStripMenuItem
            // 
            this.adicionarProdutoToolStripMenuItem.Name = "adicionarProdutoToolStripMenuItem";
            resources.ApplyResources(this.adicionarProdutoToolStripMenuItem, "adicionarProdutoToolStripMenuItem");
            this.adicionarProdutoToolStripMenuItem.Click += new System.EventHandler(this.adicionarProdutoToolStripMenuItem_Click);
            // 
            // visualizarEstoqueToolStripMenuItem
            // 
            this.visualizarEstoqueToolStripMenuItem.Name = "visualizarEstoqueToolStripMenuItem";
            resources.ApplyResources(this.visualizarEstoqueToolStripMenuItem, "visualizarEstoqueToolStripMenuItem");
            this.visualizarEstoqueToolStripMenuItem.Click += new System.EventHandler(this.visualizarEstoqueToolStripMenuItem_Click);
            // 
            // cadastrarCategoriaToolStripMenuItem
            // 
            this.cadastrarCategoriaToolStripMenuItem.Name = "cadastrarCategoriaToolStripMenuItem";
            resources.ApplyResources(this.cadastrarCategoriaToolStripMenuItem, "cadastrarCategoriaToolStripMenuItem");
            this.cadastrarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.adicionarCategoriaToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visualizarClientesToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            resources.ApplyResources(this.pedidosToolStripMenuItem, "pedidosToolStripMenuItem");
            // 
            // visualizarClientesToolStripMenuItem
            // 
            this.visualizarClientesToolStripMenuItem.Name = "visualizarClientesToolStripMenuItem";
            resources.ApplyResources(this.visualizarClientesToolStripMenuItem, "visualizarClientesToolStripMenuItem");
            // 
            // pedidosToolStripMenuItem1
            // 
            this.pedidosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPedidoToolStripMenuItem,
            this.visualizarPedidosToolStripMenuItem,
            this.adicionarStatusDePedidoToolStripMenuItem,
            this.adicionarFormaDePagamentoToolStripMenuItem,
            this.adicionarCategoriaToolStripMenuItem});
            this.pedidosToolStripMenuItem1.Name = "pedidosToolStripMenuItem1";
            resources.ApplyResources(this.pedidosToolStripMenuItem1, "pedidosToolStripMenuItem1");
            // 
            // cadastrarPedidoToolStripMenuItem
            // 
            this.cadastrarPedidoToolStripMenuItem.Name = "cadastrarPedidoToolStripMenuItem";
            resources.ApplyResources(this.cadastrarPedidoToolStripMenuItem, "cadastrarPedidoToolStripMenuItem");
            // 
            // visualizarPedidosToolStripMenuItem
            // 
            this.visualizarPedidosToolStripMenuItem.Name = "visualizarPedidosToolStripMenuItem";
            resources.ApplyResources(this.visualizarPedidosToolStripMenuItem, "visualizarPedidosToolStripMenuItem");
            // 
            // adicionarStatusDePedidoToolStripMenuItem
            // 
            this.adicionarStatusDePedidoToolStripMenuItem.Name = "adicionarStatusDePedidoToolStripMenuItem";
            resources.ApplyResources(this.adicionarStatusDePedidoToolStripMenuItem, "adicionarStatusDePedidoToolStripMenuItem");
            this.adicionarStatusDePedidoToolStripMenuItem.Click += new System.EventHandler(this.adicionarStatusDePedidoToolStripMenuItem_Click);
            // 
            // adicionarFormaDePagamentoToolStripMenuItem
            // 
            this.adicionarFormaDePagamentoToolStripMenuItem.Name = "adicionarFormaDePagamentoToolStripMenuItem";
            resources.ApplyResources(this.adicionarFormaDePagamentoToolStripMenuItem, "adicionarFormaDePagamentoToolStripMenuItem");
            // 
            // adicionarCategoriaToolStripMenuItem
            // 
            this.adicionarCategoriaToolStripMenuItem.Name = "adicionarCategoriaToolStripMenuItem";
            resources.ApplyResources(this.adicionarCategoriaToolStripMenuItem, "adicionarCategoriaToolStripMenuItem");
            this.adicionarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.adicionarCategoriaToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.pedidosToolStripMenuItem1,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versãoToolStripMenuItem,
            this.ajudaParaEsteFormulárioToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            resources.ApplyResources(this.ajudaToolStripMenuItem, "ajudaToolStripMenuItem");
            // 
            // versãoToolStripMenuItem
            // 
            this.versãoToolStripMenuItem.Name = "versãoToolStripMenuItem";
            resources.ApplyResources(this.versãoToolStripMenuItem, "versãoToolStripMenuItem");
            this.versãoToolStripMenuItem.Click += new System.EventHandler(this.versãoToolStripMenuItem_Click);
            // 
            // ajudaParaEsteFormulárioToolStripMenuItem
            // 
            this.ajudaParaEsteFormulárioToolStripMenuItem.Name = "ajudaParaEsteFormulárioToolStripMenuItem";
            resources.ApplyResources(this.ajudaParaEsteFormulárioToolStripMenuItem, "ajudaParaEsteFormulárioToolStripMenuItem");
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addProductButton
            // 
            resources.ApplyResources(this.addProductButton, "addProductButton");
            this.addProductButton.BackgroundImage = global::Lojinha.Properties.Resources.addProductButton;
            this.addProductButton.FlatAppearance.BorderSize = 0;
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.UseVisualStyleBackColor = true;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click);
            // 
            // viewStorageButton
            // 
            resources.ApplyResources(this.viewStorageButton, "viewStorageButton");
            this.viewStorageButton.BackgroundImage = global::Lojinha.Properties.Resources.viewStorageButton;
            this.viewStorageButton.FlatAppearance.BorderSize = 0;
            this.viewStorageButton.Name = "viewStorageButton";
            this.viewStorageButton.UseVisualStyleBackColor = true;
            this.viewStorageButton.Click += new System.EventHandler(this.viewStorageButton_Click);
            // 
            // addCategoryButton
            // 
            resources.ApplyResources(this.addCategoryButton, "addCategoryButton");
            this.addCategoryButton.BackgroundImage = global::Lojinha.Properties.Resources.addCategoryButton;
            this.addCategoryButton.FlatAppearance.BorderSize = 0;
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.UseVisualStyleBackColor = true;
            this.addCategoryButton.Click += new System.EventHandler(this.addCategoryButton_Click);
            // 
            // viewOrdersButton
            // 
            resources.ApplyResources(this.viewOrdersButton, "viewOrdersButton");
            this.viewOrdersButton.BackgroundImage = global::Lojinha.Properties.Resources.viewSalesButton;
            this.viewOrdersButton.FlatAppearance.BorderSize = 0;
            this.viewOrdersButton.Name = "viewOrdersButton";
            this.viewOrdersButton.UseVisualStyleBackColor = true;
            this.viewOrdersButton.Click += new System.EventHandler(this.viewOrdersButton_Click);
            // 
            // viewClientsButton
            // 
            resources.ApplyResources(this.viewClientsButton, "viewClientsButton");
            this.viewClientsButton.BackgroundImage = global::Lojinha.Properties.Resources.viewClientsButton;
            this.viewClientsButton.FlatAppearance.BorderSize = 0;
            this.viewClientsButton.Name = "viewClientsButton";
            this.viewClientsButton.UseVisualStyleBackColor = true;
            this.viewClientsButton.Click += new System.EventHandler(this.viewClientsButton_Click);
            // 
            // createUserButton
            // 
            resources.ApplyResources(this.createUserButton, "createUserButton");
            this.createUserButton.BackgroundImage = global::Lojinha.Properties.Resources.createUserButton;
            this.createUserButton.FlatAppearance.BorderSize = 0;
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // addPaymentButton
            // 
            resources.ApplyResources(this.addPaymentButton, "addPaymentButton");
            this.addPaymentButton.BackgroundImage = global::Lojinha.Properties.Resources.addPaymentButton;
            this.addPaymentButton.FlatAppearance.BorderSize = 0;
            this.addPaymentButton.Name = "addPaymentButton";
            this.addPaymentButton.UseVisualStyleBackColor = true;
            this.addPaymentButton.Click += new System.EventHandler(this.addPaymentButton_Click);
            // 
            // minimizeButton
            // 
            resources.ApplyResources(this.minimizeButton, "minimizeButton");
            this.minimizeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.minimizeButton.BackgroundImage = global::Lojinha.Properties.Resources.minimizeButton;
            this.minimizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.ForeColor = System.Drawing.Color.Black;
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // helpButton
            // 
            resources.ApplyResources(this.helpButton, "helpButton");
            this.helpButton.BackgroundImage = global::Lojinha.Properties.Resources.helpButton;
            this.helpButton.FlatAppearance.BorderSize = 0;
            this.helpButton.Name = "helpButton";
            this.helpButton.UseVisualStyleBackColor = true;
            this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
            // 
            // helpBalloon2
            // 
            this.helpBalloon2.BackgroundImage = global::Lojinha.Properties.Resources.balao2;
            resources.ApplyResources(this.helpBalloon2, "helpBalloon2");
            this.helpBalloon2.Name = "helpBalloon2";
            this.helpBalloon2.TabStop = false;
            this.helpBalloon2.Click += new System.EventHandler(this.helpBalloon2_Click);
            // 
            // retroGirlImage
            // 
            this.retroGirlImage.BackgroundImage = global::Lojinha.Properties.Resources.retroGirlHelp;
            resources.ApplyResources(this.retroGirlImage, "retroGirlImage");
            this.retroGirlImage.Name = "retroGirlImage";
            this.retroGirlImage.TabStop = false;
            this.retroGirlImage.Click += new System.EventHandler(this.retroGirlImage_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pictureBox2.BackgroundImage = global::Lojinha.Properties.Resources.logoLoja;
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // maximizeButton
            // 
            resources.ApplyResources(this.maximizeButton, "maximizeButton");
            this.maximizeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.maximizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.maximizeButton.FlatAppearance.BorderSize = 0;
            this.maximizeButton.ForeColor = System.Drawing.Color.Black;
            this.maximizeButton.Name = "maximizeButton";
            this.maximizeButton.UseVisualStyleBackColor = false;
            this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.BackgroundImage = global::Lojinha.Properties.Resources.capa;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Image = global::Lojinha.Properties.Resources.closeBtn;
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // normalSizeButton
            // 
            resources.ApplyResources(this.normalSizeButton, "normalSizeButton");
            this.normalSizeButton.BackColor = System.Drawing.SystemColors.MenuBar;
            this.normalSizeButton.BackgroundImage = global::Lojinha.Properties.Resources.normalSizeButton;
            this.normalSizeButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.normalSizeButton.FlatAppearance.BorderSize = 0;
            this.normalSizeButton.ForeColor = System.Drawing.Color.Black;
            this.normalSizeButton.Name = "normalSizeButton";
            this.normalSizeButton.UseVisualStyleBackColor = false;
            this.normalSizeButton.Click += new System.EventHandler(this.normalSizeButton_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.BackgroundImage = global::Lojinha.Properties.Resources.viewClientsButton;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipal
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Lojinha.Properties.Resources.mainScreenBG;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.normalSizeButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.helpBalloon2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.minimizeButton);
            this.Controls.Add(this.maximizeButton);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.viewOrdersButton);
            this.Controls.Add(this.viewClientsButton);
            this.Controls.Add(this.addPaymentButton);
            this.Controls.Add(this.viewStorageButton);
            this.Controls.Add(this.addProductButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.retroGirlImage);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.createUserButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaPrincipal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.helpBalloon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retroGirlImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPedidoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarUsuárioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button viewStorageButton;
        private System.Windows.Forms.Button addCategoryButton;
        private System.Windows.Forms.Button viewOrdersButton;
        private System.Windows.Forms.Button viewClientsButton;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button addPaymentButton;
        private System.Windows.Forms.Button maximizeButton;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem adicionarStatusDePedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarFormaDePagamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajudaParaEsteFormulárioToolStripMenuItem;
        private System.Windows.Forms.Button helpButton;
        private System.Windows.Forms.PictureBox retroGirlImage;
        private System.Windows.Forms.PictureBox helpBalloon2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ToolStripMenuItem adicionarCategoriaToolStripMenuItem;
        private System.Windows.Forms.Button normalSizeButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
    }
}
