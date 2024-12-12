using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SpellProgramming;

public class SpellCaster : MonoBehaviour, IEntity
{
    public DamageEffect damageEffect;
    public PullEffect pullEffect;
    public MoteMould moteMould;
    public AreaMould areaMould;
    public ThrowModifier throwModifier;
    public AssembledSpell sampleDmgSpell;
    public AssembledSpell samplePullSpell;

    void Start()
    {
        
        // TEMPORARY!!! JUST FOR TESTING!!!
        AssembledEffect sampleDamage = new (damageEffect, 2);
        AssembledEffect samplePull = new (pullEffect, 0);

        AssembledModifier sampleThrow = new (throwModifier, 6);

        AssembledMould sampleMote = new (moteMould, new List<AssembledEffect>() {sampleDamage, samplePull}, new List<AssembledModifier>() {sampleThrow});
        AssembledMould sampleArea = new (areaMould, new List<AssembledEffect>() {samplePull}, null);

        sampleDmgSpell = new AssembledSpell(new List<AssembledMould>() {sampleMote}, transform.parent.gameObject);
        samplePullSpell = new AssembledSpell(new List<AssembledMould>() {sampleArea}, transform.parent.gameObject);
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !PauseManager.isPaused)
            sampleDmgSpell.Cast();
            
        if(Input.GetMouseButtonDown(1) && !PauseManager.isPaused) 
            samplePullSpell.Cast();
    }

    public Quaternion GetRotation()
    {
        return transform.parent.transform.rotation;
    }
}