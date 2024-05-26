using System;
using System.Threading;
using System.Threading.Tasks;

namespace FinalProjectGUI
{
    private bool calcDone = false;
    private RecipeInventoryListBox recipeInventoryListBox;

    // Association: RecipeInventoryListBoxFuture<- Is aware when RecipeInventoryListBox exists
    public RecipeInventoryListBox RecipeInventoryListBox => recipeInventoryListBox;

    // Dependency: RecipeWindowsForm <- Creates
    public RecipeInventoryListBoxFuture(RecipeWindowsForm recipeWindowsForm)
    {
        recipeWindowsForm.Create(this);
    }

    public bool CheckList()
    {
        return calcDone;
    }


    // Association: Client <- Polls for existence of RecipeInventoryListBox object and fetches RecipeInventoryListBox object
    public RecipeInventoryListBox WaitForRecipes()
    {
        // Checking if calculations are completed
        if (calcDone)
        {
            return recipeInventoryListBox;
        }
        else
        {
            return null; // Return null to indicate that calculations are not done yet
        }
    }


    /* Example code to add in RecipeWindowsForm:
     * public class RecipeWindowsForm
     * {
     *      // Dependency: RecipeWindowsForm <- Creates
     *      public void Create(RecipeInventoryListBoxFuture recipeInventoryListBoxFuture)
     *      { // create RecipeInventoryListBoxFuture instance }
     * }
     */
}