﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HREngine.Bots
{
    public enum Side
    {
        NEUTRAL,
        FRIENDLY,
        OPPOSING
    }

    public enum GAME_TAGs
    {
        STATE = 204,
        TURN = 20,
        STEP = 19,
        NEXT_STEP = 198,
        TEAM_ID = 31,
        PLAYER_ID = 30,
        STARTHANDSIZE = 29,
        MAXHANDSIZE = 28,
        MAXRESOURCES = 176,
        TIMEOUT = 7,
        TURN_START,
        TURN_TIMER_SLUSH,
        GOLD_REWARD_STATE = 13,
        FIRST_PLAYER = 24,
        CURRENT_PLAYER = 23,
        HERO_ENTITY = 27,
        RESOURCES = 26,
        RESOURCES_USED = 25,
        FATIGUE = 22,
        PLAYSTATE = 17,
        CURRENT_SPELLPOWER = 291,
        MULLIGAN_STATE = 305,
        HAND_REVEALED = 348,
        CARDNAME = 185,
        CARDTEXT_INHAND = 184,
        CARDRACE = 200,
        CARDTYPE = 202,
        COST = 48,
        HEALTH = 45,
        ATK = 47,
        DURABILITY = 187,
        ARMOR = 292,
        PREDAMAGE = 318,
        TARGETING_ARROW_TEXT = 325,
        LAST_AFFECTED_BY = 18,
        ENCHANTMENT_BIRTH_VISUAL = 330,
        ENCHANTMENT_IDLE_VISUAL,
        PREMIUM = 12,
        IGNORE_DAMAGE = 1,
        IGNORE_DAMAGE_OFF = 354,
        ENTITY_ID = 53,
        DEFINITION = 52,
        OWNER = 51,
        CONTROLLER = 50,
        ZONE = 49,
        EXHAUSTED = 43,
        ATTACHED = 40,
        PROPOSED_ATTACKER = 39,
        ATTACKING = 38,
        PROPOSED_DEFENDER = 37,
        DEFENDING = 36,
        PROTECTED = 35,
        PROTECTING = 34,
        RECENTLY_ARRIVED = 33,
        DAMAGE = 44,
        TRIGGER_VISUAL = 32,
        TAUNT = 190,
        SPELLPOWER = 192,
        DIVINE_SHIELD = 194,
        CHARGE = 197,
        SECRET = 219,
        MORPH = 293,
        DIVINE_SHIELD_READY = 314,
        TAUNT_READY = 306,
        STEALTH_READY,
        CHARGE_READY,
        CREATOR = 313,
        CANT_DRAW = 232,
        CANT_PLAY = 231,
        CANT_DISCARD = 230,
        CANT_DESTROY = 229,
        CANT_TARGET = 228,
        CANT_ATTACK = 227,
        CANT_EXHAUST = 226,
        CANT_READY = 225,
        CANT_REMOVE_FROM_GAME = 224,
        CANT_SET_ASIDE = 223,
        CANT_DAMAGE = 222,
        CANT_HEAL = 221,
        CANT_BE_DESTROYED = 247,
        CANT_BE_TARGETED = 246,
        CANT_BE_ATTACKED = 245,
        CANT_BE_EXHAUSTED = 244,
        CANT_BE_READIED = 243,
        CANT_BE_REMOVED_FROM_GAME = 242,
        CANT_BE_SET_ASIDE = 241,
        CANT_BE_DAMAGED = 240,
        CANT_BE_HEALED = 239,
        CANT_BE_SUMMONING_SICK = 253,
        CANT_BE_DISPELLED = 314,
        INCOMING_DAMAGE_CAP = 238,
        INCOMING_DAMAGE_ADJUSTMENT = 237,
        INCOMING_DAMAGE_MULTIPLIER = 236,
        INCOMING_HEALING_CAP = 235,
        INCOMING_HEALING_ADJUSTMENT = 234,
        INCOMING_HEALING_MULTIPLIER = 233,
        FROZEN = 260,
        JUST_PLAYED,
        LINKEDCARD,
        ZONE_POSITION,
        CANT_BE_FROZEN,
        COMBO_ACTIVE = 266,
        CARD_TARGET,
        NUM_CARDS_PLAYED_THIS_TURN = 269,
        CANT_BE_TARGETED_BY_OPPONENTS,
        NUM_TURNS_IN_PLAY,
        SUMMONED = 205,
        ENRAGED = 212,
        SILENCED = 188,
        WINDFURY,
        LOYALTY = 216,
        DEATHRATTLE,
        ADJACENT_BUFF = 350,
        STEALTH = 191,
        BATTLECRY = 218,
        NUM_TURNS_LEFT = 272,
        OUTGOING_DAMAGE_CAP,
        OUTGOING_DAMAGE_ADJUSTMENT,
        OUTGOING_DAMAGE_MULTIPLIER,
        OUTGOING_HEALING_CAP,
        OUTGOING_HEALING_ADJUSTMENT,
        OUTGOING_HEALING_MULTIPLIER,
        INCOMING_ABILITY_DAMAGE_ADJUSTMENT,
        INCOMING_COMBAT_DAMAGE_ADJUSTMENT,
        OUTGOING_ABILITY_DAMAGE_ADJUSTMENT,
        OUTGOING_COMBAT_DAMAGE_ADJUSTMENT,
        OUTGOING_ABILITY_DAMAGE_MULTIPLIER,
        OUTGOING_ABILITY_DAMAGE_CAP,
        INCOMING_ABILITY_DAMAGE_MULTIPLIER,
        INCOMING_ABILITY_DAMAGE_CAP,
        OUTGOING_COMBAT_DAMAGE_MULTIPLIER,
        OUTGOING_COMBAT_DAMAGE_CAP,
        INCOMING_COMBAT_DAMAGE_MULTIPLIER,
        INCOMING_COMBAT_DAMAGE_CAP,
        IS_MORPHED = 294,
        TEMP_RESOURCES,
        RECALL_OWED,
        NUM_ATTACKS_THIS_TURN,
        NEXT_ALLY_BUFF = 302,
        MAGNET,
        FIRST_CARD_PLAYED_THIS_TURN,
        CARD_ID = 186,
        CANT_BE_TARGETED_BY_ABILITIES = 311,
        SHOULDEXITCOMBAT,
        PARENT_CARD = 316,
        NUM_MINIONS_PLAYED_THIS_TURN,
        CANT_BE_TARGETED_BY_HERO_POWERS = 332,
        COMBO = 220,
        ELITE = 114,
        CARD_SET = 183,
        FACTION = 201,
        RARITY = 203,
        CLASS = 199,
        MISSION_EVENT = 6,
        FREEZE = 208,
        RECALL = 215,
        SILENCE = 339,
        COUNTER,
        ARTISTNAME = 342,
        FLAVORTEXT = 351,
        FORCED_PLAY,
        LOW_HEALTH_THRESHOLD,
        SPELLPOWER_DOUBLE = 356,
        HEALING_DOUBLE,
        NUM_OPTIONS_PLAYED_THIS_TURN,
        NUM_OPTIONS,
        TO_BE_DESTROYED,
        HEALTH_MINIMUM = 337,
        AURA = 362,
        POISONOUS,
        HOW_TO_EARN,
        HOW_TO_EARN_GOLDEN,
        TAG_HERO_POWER_DOUBLE,
        TAG_AI_MUST_PLAY,
        NUM_MINIONS_PLAYER_KILLED_THIS_TURN,
        NUM_MINIONS_KILLED_THIS_TURN,
        AFFECTED_BY_SPELL_POWER,
        EXTRA_DEATHRATTLES,
        START_WITH_1_HEALTH,
        IMMUNE_WHILE_ATTACKING,
        MULTIPLY_HERO_DAMAGE,
        MULTIPLY_BUFF_VALUE,
        CUSTOM_KEYWORD_EFFECT,
        TOPDECK
    }
    
    public enum TAG_ZONE
    {
        INVALID,
        PLAY,
        DECK,
        HAND,
        GRAVEYARD,
        REMOVEDFROMGAME,
        SETASIDE,
        SECRET
    }

    public enum TAG_MULLIGAN
    {
        INVALID,
        INPUT,
        DEALING,
        WAITING,
        DONE
    }

    public enum TAG_CLASS
    {
        INVALID,
        DEATHKNIGHT,
        DRUID,
        HUNTER,
        MAGE,
        PALADIN,
        PRIEST,
        ROGUE,
        SHAMAN,
        WARLOCK,
        WARRIOR,
        DREAM

    }

    public enum TAG_CARDTYPE
    {
        INVALID,
        GAME,
        PLAYER,
        HERO,
        MINION,
        ABILITY,
        ENCHANTMENT,
        WEAPON,
        ITEM,
        TOKEN,
        HERO_POWER
    }


    public enum AttackType
    {
        INVALID,
        REGULAR,
        PROPOSED,
        CANCELED,
        ONLY_ATTACKER,
        ONLY_DEFENDER,
        ONLY_PROPOSED_ATTACKER,
        ONLY_PROPOSED_DEFENDER,
        WAITING_ON_PROPOSED_ATTACKER,
        WAITING_ON_PROPOSED_DEFENDER,
        WAITING_ON_ATTACKER,
        WAITING_ON_DEFENDER
    }

    public enum TAG_PLAYSTATE
    {
        INVALID,
        PLAYING,
        WINNING,
        LOSING,
        WON,
        LOST,
        TIED,
        DISCONNECTED,
        QUIT
    }


    public enum TAG_RACE
    {
        INVALID,
        BLOODELF,
        DRAENEI,
        DWARF,
        GNOME,
        GOBLIN,
        HUMAN,
        NIGHTELF,
        ORC,
        TAUREN,
        TROLL,
        UNDEAD,
        WORGEN,
        GOBLIN2,
        MURLOC,
        DEMON,
        SCOURGE,
        MECHANICAL,
        ELEMENTAL,
        OGRE,
        PET,
        TOTEM,
        NERUBIAN,
        PIRATE,
        DRAGON
    }

    public enum TAG_STATE
    {
        INVALID,
        LOADING,
        RUNNING,
        COMPLETE
    }

    public enum TAG_STEP
    {
        INVALID,
        BEGIN_FIRST,
        BEGIN_SHUFFLE,
        BEGIN_DRAW,
        BEGIN_MULLIGAN,
        MAIN_BEGIN,
        MAIN_READY,
        MAIN_RESOURCE,
        MAIN_DRAW,
        MAIN_START,
        MAIN_ACTION,
        MAIN_COMBAT,
        MAIN_END,
        MAIN_NEXT,
        FINAL_WRAPUP,
        FINAL_GAMEOVER,
        MAIN_CLEANUP,
        MAIN_START_TRIGGERS
    }

    public enum CHOICE_TYPE
    {
        INVALID,
        MULLIGAN,
        GENERAL
    }
}
