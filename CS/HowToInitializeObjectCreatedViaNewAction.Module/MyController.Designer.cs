namespace HowToInitializeObjectCreatedViaNewAction.Module {
   partial class MyController {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary> 
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing) {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Component Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent() {
         // 
         // MyController
         // 
         this.TargetObjectType = typeof(DevExpress.Persistent.BaseImpl.Task);
         this.TargetViewNesting = DevExpress.ExpressApp.Nesting.Root;
         this.FrameAssigned += new System.EventHandler(this.MyController_FrameAssigned);

      }

      #endregion
   }
}