using Our.Umbraco.Ditto;

namespace DemoApp.ComponentModel.Processors
{
    public class AddNumberProcessorContext : DittoProcessorContext
    {
        public int Number { get; set; }
    }
}