using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeedReviewOfRolesCoMono : MonoBehaviour
{
    public GameMakingRoles[] m_rolesRequired;
}

public enum GameMakingRoles { Artist, Coder, GameDesigner, CEO, CTO, Commercial, StoryTeller, NotDefined}