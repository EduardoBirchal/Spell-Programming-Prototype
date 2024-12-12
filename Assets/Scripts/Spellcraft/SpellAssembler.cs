using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Unity.VisualScripting;
using Unity.VisualScripting.FullSerializer;
using UnityEditor.Timeline.Actions;
using UnityEngine;

namespace SpellProgramming {
    public class AssembledMould
    {
        public GameObject caster;
        public GenericMould mouldSO;
        public List<AssembledEffect> effectList;
        public List<AssembledModifier> modifierList;

        public AssembledMould(GenericMould mouldSO, List<AssembledEffect> effectList, List<AssembledModifier> modifierList) 
        {
            this.mouldSO = mouldSO;
            this.effectList = effectList;
            this.modifierList = modifierList;
        }

        public virtual void Create(GameObject caster)
        {
            this.caster = caster;
            mouldSO.Create(this.caster, effectList, modifierList);
        }
    }

    public class AssembledEffect
    {
        public float power;
        public GenericEffect effectSO;

        public AssembledEffect(GenericEffect effectSO, int numAmplifiers)
        {
            this.effectSO = effectSO;

            this.power = CalculateAmplifiers(effectSO.basePower, numAmplifiers);
        }

        public virtual void Activate (GameObject target, Vector3 location, float multiplier, Vector2 direction = new Vector2()) 
        {
            effectSO.Activate(target, location, power * multiplier, direction);
        }

        private float CalculateAmplifiers(float baseNum, int numAmplifiers)
        {
            return baseNum + (baseNum * numAmplifiers / 2);
        }
    }

    public class AssembledModifier
    {
        public float power;
        public GenericModifier modifierSO;

        public AssembledModifier(GenericModifier modifierSO, float power)
        {
            this.modifierSO = modifierSO;
            this.power = power;
        }

        public void Apply(IEntity casterInfo, GameObject targetMould)
        {
            Debug.Log("modifierSO = " + modifierSO);
            Type scriptType = modifierSO.associatedScript.GetType();
            targetMould.AddComponent(scriptType);

            ModifierScript appliedModifier = (ModifierScript) targetMould.GetComponent(scriptType);

            appliedModifier.casterInfo = casterInfo;
            appliedModifier.power = this.power;
        }
    }

    public class AssembledSpell
    {
        public List<AssembledMould> mouldList;
        public float manaCost;
        public GameObject caster;
        
        public AssembledSpell(List<AssembledMould> mouldList, GameObject caster)
        {
            Debug.Log("mouldList = " + mouldList + " manaCost = " + manaCost + " caster = " + caster);

            this.mouldList = mouldList;
            this.caster = caster;
        }

        public void Cast()
        {
            foreach (AssembledMould mould in mouldList) {
                mould.Create(caster);
            }
        }
    }
}

public interface IEntity
{
    public Quaternion GetRotation();
}

public class SpellAssembler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
