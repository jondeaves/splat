using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    PropFactory propFactory;
    EnemyFactory enemyFactor;

	void Start () 
    {
        propFactory = GetComponent<PropFactory>();
        enemyFactor = GetComponent<EnemyFactory>();

        if (Game.NumberOfProps < Game.MaxProps)
        {
            propFactory.SpawnInProps(Game.MaxProps - Game.NumberOfProps);
        }

        if (Game.NumberOfEnemys < Game.MaxEnemys)
        {
            enemyFactor.SpawnInEnemy(Game.MaxEnemys - Game.NumberOfEnemys);
        }

	}

}
