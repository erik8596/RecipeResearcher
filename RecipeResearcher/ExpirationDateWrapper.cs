namespace FinalProjectGUI
{
    // Inheritance: ExpirationDateWrapper inherits from AbstractWrapper
    public class ExpirationDateWrapper : AbstractWrapper
    {
        private string expirationDate;

        // Initializes expirationDate and wrappedInventory:
        public ExpirationDateWrapper(string expirationDate, AbstractRecipeInventoryListBoxIF wrappedInventory) : base(wrappedInventory)
        {
            this.expirationDate = expirationDate;
        }

        // Override Display to add decoration for expiration date:
        public override void Display()
        {
            base.Display();

            // Decorate by displaying the expiration date:
            Console.WriteLine("Expiration Date: " + expirationDate);
        }
    }
}