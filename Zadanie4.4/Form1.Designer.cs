
namespace Zadanie4._4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.поставщикиTableAdapter1 = new Zadanie4._4.RBProductDataSetTableAdapters.ПоставщикиTableAdapter();
            this.rbProductDataSet1 = new Zadanie4._4.RBProductDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.rbProductDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // поставщикиTableAdapter1
            // 
            this.поставщикиTableAdapter1.ClearBeforeFill = true;
            // 
            // rbProductDataSet1
            // 
            this.rbProductDataSet1.DataSetName = "RBProductDataSet";
            this.rbProductDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.rbProductDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private RBProductDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter1;
        private RBProductDataSet rbProductDataSet1;
    }
}

