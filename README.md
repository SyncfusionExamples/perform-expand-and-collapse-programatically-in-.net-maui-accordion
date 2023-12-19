# perform-expand-and-collapse-programatically-in-.net-maui-accordion
This example demonstrates about how to perform expand and collapse functionality through programatically in .NET MAUI Accordion (SfAccordion).

How to expand or collapse Accordion programmatically in Maui(SfAccordion)

You can programmatically expand or collapse the AccordionItem in Maui SfAccordion by binding the model property to AccordionItem.IsExpanded property.
 
XAML

IsExpanded model property is bound to IsExpanded property of AccordionItem to expand or collapse when update property value programmatically.
``` xml 
<DataTemplate>
    <syncfusion:AccordionItem IsExpanded="{Binding IsExpand}">
        <syncfusion:AccordionItem.Header>
            <Grid HeightRequest="60">
                <Label Text="{Binding Name}" FontSize="Medium"/>
            </Grid>
        </syncfusion:AccordionItem.Header>
        <syncfusion:AccordionItem.Content>
            <Grid>
                <Grid>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="*"/>
                        <RowDefinition Height="50"/>
                    </Grid.RowDefinitions>
                    <Label Text="{Binding Description}"/>
                    <Button x:Name="btn" Grid.Row="1" Text="{Binding Name}" Command="{Binding Path=BindingContext.ButtonCommand, Source={x:Reference Accordion}}" CommandParameter="{x:Reference btn}"/>
                </Grid>
            </Grid>
        </syncfusion:AccordionItem.Content>
    </syncfusion:AccordionItem>
</DataTemplate>
```
C#

OnExpandCollapse is used to change the IsExpand property to expand or collapse the item.
 
``` csharp
public class ItemInfoRepository
{
    public Command<object> ExpandCollapse{ get; set; }
 
    public ItemInfoRepository()
    {
        ExpandCollapse= new Command<object>(OnExpandCollapse);
    }
    
    private void OnExpandCollapse (object obj)
    {
        var item = (obj as Button).BindingContext as ItemInfo;
        item.IsExpand = !item.IsExpand;
    }
}
```
