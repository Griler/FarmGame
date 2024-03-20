using System.Collections;
using System.Collections.Generic;
using Item;
using Config;
using UnityEngine;

namespace Config
{
    class SetMap
    {
         Dictionary<int, string> mapState = new Dictionary<int, string>();
         Dictionary<string, string> mapStateSprite = new Dictionary<string, string>();

        public SetMap()
        {
            Debug.Log("run");
            setUpMap();
        }

        void setUpMap()
        {
            mapState.Add(1, "Start");
            mapState.Add(2, "Mid");
            mapState.Add(3, "End");
            mapState.Add(4, "Result");

            mapStateSprite.Add("Start","plants free_0");
            mapStateSprite.Add("Mid","plants free_1:plant free_2");
            mapStateSprite.Add("End","plants free_3");
            mapStateSprite.Add("Result","plants free_4");
        }

        public string getStateNameById(int id)
        {
            return mapState[id];
        }
        
        public string getSpriteByState(string stateName)
        {
            return mapStateSprite[stateName];
        }
    }
}

public class PlantStateManager : MonoBehaviour
{
    [SerializeField] public List<Sprite> SpriteList = new List<Sprite>();

    private BaseItemState currentState;

    private PlantStartState newState = new PlantStartState();
    private PlantMidState midState = new PlantMidState();
    private PlantEndStart endState = new PlantEndStart();
    private PlantResultState resultState = new PlantResultState();

    void Start()
    {
        currentState = newState;
        currentState.EnterState(this);
    }

    void switchState(BaseItemState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }
    public string getSpriteByState(string stateName)
    {
         SetMap gameCf = new SetMap();
         return gameCf.getSpriteByState(stateName);
    }
}