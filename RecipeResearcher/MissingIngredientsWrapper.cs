namespace FinalProjectGUI
{
	// Concrete decorator: Highlights missing ingredients
	public class MissingIngredientsWrapper : AbstractWrapper
	{
		private List<string> missingIngredients;

		public MissingIngredientsWrapper(List<string> missingIngredients, AbstractRecipeInventoryListBoxIF wrappedInventory) : base(wrappedInventory)
		{
			this.missingIngredients = missingIngredients;
		}

		// Overriding Display to add decoration for missing ingredients:
		public override void Display()
		{
			base.Display();

			// Decorate by displaying missing ingredients:
			Console.WriteLine("Missing Ingredients:");

			foreach (string ingredient in missingIngredients)
			{
				Console.WriteLine("- " + ingredient);
			}
		}
	}
}