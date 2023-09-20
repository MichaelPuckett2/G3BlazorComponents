namespace G3BlazorComponents.BaseComponents.Models;

[ExcludeFromCodeCoverage(Justification = "POCO")]
public class SelectableItem<TItem>
{
    private bool isSelected;

    public SelectableItem(TItem item, int index)
    {
        Item = item;
        Index = index;
    }

    public event Action<SelectableItem<TItem>> Selected = delegate { };
    public event Action<SelectableItem<TItem>> Unselected = delegate { };

    public TItem Item { get; }
    public int Index { get; }

    public bool IsSelected
    {
        get => isSelected;
        set
        {
            if (isSelected == value) return;
            isSelected = value;
            if (isSelected)
            {
                Selected.Invoke(this);
            }
            else
            {
                Unselected.Invoke(this);
            }
        }
    }

    public static SelectableItem<TItem> Empty { get; } = new SelectableItem<TItem>(default!, default);
}
