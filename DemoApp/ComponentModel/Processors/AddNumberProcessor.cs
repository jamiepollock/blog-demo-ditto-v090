using Our.Umbraco.Ditto;

namespace DemoApp.ComponentModel.Processors
{
    [DittoProcessorMetaData(ContextType = typeof(AddNumberProcessorContext))]
    public class AddNumberProcessor : DittoProcessorAttribute
    {

        public override object ProcessValue()
        {
            if (Value is int && Context is AddNumberProcessorContext)
            {
                var castContext = (AddNumberProcessorContext)Context;

                if (castContext != null)
                {
                    return ((int) Value) + castContext.Number;
                }
            }

            return Value;
        }
    }
}