using UnityEngine;

namespace Item
{
    public class PlantStartState : BaseItemState
    {
        public override string NAME_STATE => "Start";
        public override void EnterState(PlantStateManager plantStateManager)
        {
            SpriteRenderer spriteRenderer = plantStateManager.GetComponent<SpriteRenderer>();
            string spriteName = plantStateManager.getSpriteByState(NAME_STATE);
            Sprite sprite = plantStateManager.SpriteList.Find(sprite => sprite.name == spriteName);
            if(sprite) spriteRenderer.sprite = sprite;
            else Debug.Log("không tìm thấy tên sprite");
            Debug.Log(this);
        }

        public override void UpdateState(PlantStateManager plantStateManager)
        {
        
        }

    }
}