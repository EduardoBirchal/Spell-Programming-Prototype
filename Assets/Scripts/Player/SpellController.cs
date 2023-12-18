using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellModifier
{
    public GenericModifier modifierSO;

}

public class SpellGlyph
{
    public List <SpellGlyph> connectedGlyphs;
    public List <GenericModifier> connectedModifiers;
}

public class Spell 
{
    public float manaCost;

    public List<SpellGlyph> glyphTree;
}

public class SpellController : MonoBehaviour
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
