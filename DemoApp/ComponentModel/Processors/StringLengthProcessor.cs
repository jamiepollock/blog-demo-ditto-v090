using Our.Umbraco.Ditto;

namespace DemoApp.ComponentModel.Processors
{
    public class StringLengthProcessor : DittoProcessorAttribute
    {
        public override object ProcessValue()
        {
            return Value == null ? 0 : Value.ToString().Length;
        }
    }
}