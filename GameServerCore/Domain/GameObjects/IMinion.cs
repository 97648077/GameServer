﻿using GameServerCore.Enums;

namespace GameServerCore.Domain.GameObjects
{
    public interface IMinion : IObjAiBase
    {
        /// <summary>
        /// Unit which spawned this minion.
        /// </summary>
        IObjAiBase Owner { get; }
        /// <summary>
        /// Whether or not this minion is considered a clone of its owner.
        /// </summary>
        bool IsClone { get; }
        /// <summary>
        /// Whether or not this minion should ignore collisions.
        /// </summary>
        bool IgnoresCollision { get; }
        /// <summary>
        /// Whether or not this minion is considered a ward.
        /// </summary>
        bool IsWard { get; }
        /// <summary>
        /// Whether or not this minion is a LaneMinion.
        /// </summary>
        bool IsLaneMinion { get; }
        /// <summary>
        /// Whether or not this minion is considered a pet.
        /// </summary>
        bool IsPet { get; }
        /// <summary>
        /// Whether or not this minion is targetable at all.
        /// </summary>
        bool IsTargetable { get; }
        /// <summary>
        /// Internal name of the minion.
        /// </summary>
        string Name { get; }
        /// <summary>
        /// Only unit which is allowed to see this minion.
        /// </summary>
        IObjAiBase VisibilityOwner { get; }

        void PauseAi(bool pause);
    }
}