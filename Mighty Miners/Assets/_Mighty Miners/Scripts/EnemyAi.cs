using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAi : MonoBehaviour
{
    public NavMeshAgent agent;

    public Transform player;

    public LayerMask whatIsGround, whatIsPlayer;

    // For fist animation
    public GameObject fist;
    private Animator anim;

    public GameObject damageZone;

    // Attack
    public float timeBetweenAttacks;
    bool alreadyAttacked;

    // States
    public float sightRange, attackRange;
    public bool playerInSightRange, playerInAttackRange;

    private void Awake()
    {
        //player = GameObject.Find("XR Rig").transform;
        agent = GetComponent<NavMeshAgent>();

        anim = fist.GetComponent<Animator>();

        damageZone.SetActive(false);
    }

    private void Update()
    {
        // Checks if player is in range
        playerInSightRange = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);

        // Enemy states
        if (playerInSightRange && !playerInAttackRange) ChasePlayer();
        if (playerInAttackRange && playerInSightRange) AttackPlayer();
    }

    private void ChasePlayer()
    {
        agent.SetDestination(player.position);
    }
    
    private void AttackPlayer()
    {
        // Stops enemy when attacking and makes them look at player
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        if (!alreadyAttacked)
        {
            // Attack code goes here

            anim.SetTrigger("Attack");
            damageZone.SetActive(true);

            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttacks);
        }
    }

    private void ResetAttack()
    {
        alreadyAttacked = false;
        damageZone.SetActive(false);
    }
}
