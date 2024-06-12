using Evergine.Framework;
using Evergine.Framework.Graphics;

namespace SmartCityDemo.Components
{
    public class BuildingComponent : Component
    {
        [BindComponent]
        public Transform3D Transform;

        [BindComponent(source:BindComponentSource.Children)]
        public PushpinComponent PushpinComponent;

        [BindComponent(source: BindComponentSource.Children)]
        public ColapseComponent ColapseComponent;

        public void Select()
        {
            this.ColapseComponent.Show();
        }

        public void Unselect()
        {
            this.ColapseComponent.Hide();
        }
    }
}
