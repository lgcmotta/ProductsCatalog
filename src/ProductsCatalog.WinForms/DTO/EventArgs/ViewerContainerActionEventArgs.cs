﻿namespace ProductsCatalog.WinForms.DTO.EventArgs
{
    public class ViewerContainerActionEventArgs : System.EventArgs
    {
        public enum Buttons
        {
            Add,
            Edit,
        }

        public Buttons Action { get; set; }

        public ProductDto Product { get; set; }
    }
}