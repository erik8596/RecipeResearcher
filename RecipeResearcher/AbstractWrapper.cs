namespace FinalProjectGUI
{
    public class AbstractWrapper : AbstractRecipeInventoryListBoxIF
    {

        private AbstractRecipeInventoryListBoxIF wrappedInventory;

        // Realization/implementation relationship: AbstractWrapper realizes AbstractRecipeInventoryListBoxIF
        // 1 to 1 association with "Extends ->" tag
        public AbstractWrapper(AbstractRecipeInventoryListBoxIF wrappedInventory)
        {
            this.wrappedInventory = wrappedInventory;
        }

        // Display the recipe with decorations:
        public virtual void Display()
        {
            // Delegate display to the wrapped inventory:
            if (wrappedInventory != null)
                wrappedInventory.Display();
        }
    }
}