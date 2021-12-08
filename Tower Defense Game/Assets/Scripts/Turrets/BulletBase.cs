using UnityEngine;

public class BulletBase : MonoBehaviour
{
    protected Transform target;
    protected float damage;

    protected virtual void Damage(Transform enemy)
    {
        Enemy enemyComponent = enemy.GetComponent<Enemy>();

        if (enemyComponent != null)
        {
            //float tempDamage = damage - enemyComponent.dfense;

            //if (tempDamage < 0)
            //{
            //    tempDamage = 0;
            //}

            enemyComponent.TakeDamage(damage);
        }
    }
}
