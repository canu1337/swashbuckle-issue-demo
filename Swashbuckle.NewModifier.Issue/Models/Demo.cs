using Swashbuckle.NewModifier.Issue.Controllers;

namespace Swashbuckle.NewModifier.Issue.Models
{
    public class Demo : DemoLight
    {
        public new Issue Issue { get; set; }
    }
}
