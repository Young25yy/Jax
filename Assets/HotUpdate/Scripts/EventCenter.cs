using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum EventType
{
    PlayerHPChange,
    EnemyHPChange,
    PlayerDead,
    EnemyDead,
    SkillCDChange,
}
public class EventCenter
{
    private static EventCenter instance = new EventCenter();
    public static EventCenter Instance => instance;
    private Dictionary<EventType, Delegate> events = new Dictionary<EventType, Delegate>();
    public void AddListener(EventType type, Action callBack)
    {
        if (events.ContainsKey(type))
        {
            events[type] = Delegate.Combine(events[type], callBack);
        }
        else
        {
            events.Add(type, callBack);
        }
    }
    public void AddListener<T>(EventType type, Action<T> callBack)
    {
        if (events.ContainsKey(type))
        {
            events[type] = Delegate.Combine(events[type], callBack);
        }
        else
        {
            events.Add(type, callBack);
        }
    }
    public void RemoveListener(EventType type, Action callBack)
    {
        if (events.ContainsKey(type))
        {
            events[type] = Delegate.Remove(events[type], callBack);
            if (events[type] == null)
            {
                events.Remove(type);
            }
        }
    }
    public void RemoveListener<T>(EventType type, Action<T> callBack)
    {
        if (events.ContainsKey(type))
        {
            events[type] = Delegate.Remove(events[type], callBack);
            if (events[type] == null)
            {
                events.Remove(type);
            }
        }
    }
    public void TriggerEvent(EventType type)
    {
        if (events.ContainsKey(type))
        {
            (events[type] as Action)?.Invoke();
        }
    }
    public void TriggerEvent<T>(EventType type, T data)
    {
        if (events.ContainsKey(type))
        {
            (events[type] as Action<T>)?.Invoke(data);
        }
    }
}
