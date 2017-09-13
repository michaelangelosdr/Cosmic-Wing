using UnityEngine;
using System.Collections;

public class PlayerAttack : MonoBehaviour {

	public enum AttackType
	{
		NORMAL = 0,
		POWERED = 1,
		SPLIT = 2,
	}

	public float shotDelay;
	bool shootAllow = true;

	[SerializeField] Pool_BulletController NBullets_Con; 
	[SerializeField] Pool_BulletController PBullets_Con;
	[SerializeField] Pool_BulletController SBullets_Con;
	Pool_BulletController currentPoolController;


	AttackType currentType = AttackType.NORMAL;

	Dictionary<string, AttackType> attackMap;
	Dictionary<AttackType,Pool_BulletController> attackPool;

	// Use this for initialization
	void Start () {
		currentPoolController = Bullets_Con;
	
		attackMap = new Dictionary<string, AttackType> ();

		attackMap.add ("00", AttackType.NORMAL);
		attackMap.add ("01", AttackType.POWERED);
		attackMap.add ("02", AttackType.SPLIT);

		attackPool = new Dictionary<AttackType, Pool_BulletController> ();
		attackPool.add (AttackType.NORMAL, NBullets_Con);
		attackPool.add (AttackType.POWERED, PBullets_Con);
		attackPool.add (AttackType.SPLIT, SBullets_Con);

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	public void ShootProjectile()
	{
		StartCoroutine ();

	}
	IEnumerator DelayShooting()
	{
		shootAllow = false;
		yield return new WaitForSeconds (shotDelay);
	}
}
