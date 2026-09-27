using System.Collections.Generic;
public class AOTGenericReferences : UnityEngine.MonoBehaviour
{

	// {{ AOT assemblies
	public static readonly IReadOnlyList<string> PatchedAOTAssemblyList = new List<string>
	{
		"LitJSON.dll",
		"UniTask.dll",
		"UnityEngine.CoreModule.dll",
		"YooAsset.dll",
		"mscorlib.dll",
	};
	// }}

	// {{ constraint implement type
	// }} 

	// {{ AOT generic types
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<AudioManager.<PlayMusic>d__9>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<AudioManager.<PlaySound>d__11>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<AudioManager.<PlaySoundAt>d__13>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<GameDataManager.<Init>d__8>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<JsonManager.<LoadData>d__5<object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<Show.<PlayAn>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<UIManager.<SetCanvas>d__6>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask.<>c<UIManager.<ShowPanel>d__7<object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<AudioManager.<PlayMusic>d__9>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<AudioManager.<PlaySound>d__11>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<AudioManager.<PlaySoundAt>d__13>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<GameDataManager.<Init>d__8>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<JsonManager.<LoadData>d__5<object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<Show.<PlayAn>d__2>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<UIManager.<SetCanvas>d__6>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTask<UIManager.<ShowPanel>d__7<object>,object>
	// Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>
	// Cysharp.Threading.Tasks.CompilerServices.IStateMachineRunnerPromise<object>
	// Cysharp.Threading.Tasks.ITaskPoolNode<object>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.IUniTaskSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.IUniTaskSource<object>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.Awaiter<object>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.IsCanceledSource<object>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask.MemoizeSource<object>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// Cysharp.Threading.Tasks.UniTask<System.ValueTuple<byte,object>>
	// Cysharp.Threading.Tasks.UniTask<object>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<Cysharp.Threading.Tasks.AsyncUnit>
	// Cysharp.Threading.Tasks.UniTaskCompletionSourceCore<object>
	// System.Action<SkillCDData>
	// System.Action<float>
	// System.Action<int>
	// System.Action<object,object>
	// System.Action<object>
	// System.Collections.Generic.ArraySortHelper<int>
	// System.Collections.Generic.ArraySortHelper<object>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.Comparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.Comparer<byte>
	// System.Collections.Generic.Comparer<int>
	// System.Collections.Generic.Comparer<object>
	// System.Collections.Generic.Dictionary.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.KeyCollection<int,object>
	// System.Collections.Generic.Dictionary.KeyCollection<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection.Enumerator<object,object>
	// System.Collections.Generic.Dictionary.ValueCollection<int,object>
	// System.Collections.Generic.Dictionary.ValueCollection<object,object>
	// System.Collections.Generic.Dictionary<int,object>
	// System.Collections.Generic.Dictionary<object,object>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.EqualityComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.EqualityComparer<byte>
	// System.Collections.Generic.EqualityComparer<int>
	// System.Collections.Generic.EqualityComparer<object>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.ICollection<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.ICollection<int>
	// System.Collections.Generic.ICollection<object>
	// System.Collections.Generic.IComparer<int>
	// System.Collections.Generic.IComparer<object>
	// System.Collections.Generic.IDictionary<object,LitJson.ArrayMetadata>
	// System.Collections.Generic.IDictionary<object,LitJson.ObjectMetadata>
	// System.Collections.Generic.IDictionary<object,LitJson.PropertyMetadata>
	// System.Collections.Generic.IDictionary<object,object>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerable<int>
	// System.Collections.Generic.IEnumerable<object>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<int,object>>
	// System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<object,object>>
	// System.Collections.Generic.IEnumerator<int>
	// System.Collections.Generic.IEnumerator<object>
	// System.Collections.Generic.IEqualityComparer<int>
	// System.Collections.Generic.IEqualityComparer<object>
	// System.Collections.Generic.IList<int>
	// System.Collections.Generic.IList<object>
	// System.Collections.Generic.KeyValuePair<int,object>
	// System.Collections.Generic.KeyValuePair<object,object>
	// System.Collections.Generic.List.Enumerator<int>
	// System.Collections.Generic.List.Enumerator<object>
	// System.Collections.Generic.List<int>
	// System.Collections.Generic.List<object>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.ObjectComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.ObjectComparer<byte>
	// System.Collections.Generic.ObjectComparer<int>
	// System.Collections.Generic.ObjectComparer<object>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Collections.Generic.ObjectEqualityComparer<System.ValueTuple<byte,object>>
	// System.Collections.Generic.ObjectEqualityComparer<byte>
	// System.Collections.Generic.ObjectEqualityComparer<int>
	// System.Collections.Generic.ObjectEqualityComparer<object>
	// System.Collections.ObjectModel.ReadOnlyCollection<int>
	// System.Collections.ObjectModel.ReadOnlyCollection<object>
	// System.Comparison<int>
	// System.Comparison<object>
	// System.Func<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Func<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Func<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Func<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Func<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Func<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Func<System.ValueTuple<byte,object>>
	// System.Func<byte>
	// System.Func<int>
	// System.Func<object,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Func<object,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Func<object,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Func<object,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Func<object,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Func<object,System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Func<object,System.ValueTuple<byte,object>>
	// System.Func<object,object>
	// System.Func<object>
	// System.Predicate<int>
	// System.Predicate<object>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<System.ValueTuple<byte,object>>
	// System.Runtime.CompilerServices.AsyncTaskMethodBuilder<object>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<System.ValueTuple<byte,object>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable.ConfiguredTaskAwaiter<object>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<System.ValueTuple<byte,object>>
	// System.Runtime.CompilerServices.ConfiguredTaskAwaitable<object>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<System.ValueTuple<byte,object>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable.ConfiguredValueTaskAwaiter<object>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<System.ValueTuple<byte,object>>
	// System.Runtime.CompilerServices.ConfiguredValueTaskAwaitable<object>
	// System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Runtime.CompilerServices.TaskAwaiter<System.ValueTuple<byte,object>>
	// System.Runtime.CompilerServices.TaskAwaiter<object>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<System.ValueTuple<byte,object>>
	// System.Runtime.CompilerServices.ValueTaskAwaiter<object>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<System.ValueTuple<byte,object>>
	// System.Threading.Tasks.ContinuationTaskFromResultTask<object>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Threading.Tasks.Sources.IValueTaskSource<System.ValueTuple<byte,object>>
	// System.Threading.Tasks.Sources.IValueTaskSource<object>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Threading.Tasks.Task<System.ValueTuple<byte,object>>
	// System.Threading.Tasks.Task<object>
	// System.Threading.Tasks.TaskFactory<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Threading.Tasks.TaskFactory<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Threading.Tasks.TaskFactory<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Threading.Tasks.TaskFactory<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Threading.Tasks.TaskFactory<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Threading.Tasks.TaskFactory<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Threading.Tasks.TaskFactory<System.ValueTuple<byte,object>>
	// System.Threading.Tasks.TaskFactory<object>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<System.ValueTuple<byte,object>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask.<>c<object>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<System.ValueTuple<byte,object>>
	// System.Threading.Tasks.ValueTask.ValueTaskSourceAsTask<object>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.Threading.Tasks.ValueTask<System.ValueTuple<byte,object>>
	// System.Threading.Tasks.ValueTask<object>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,System.ValueTuple<byte,object>>>
	// System.ValueTuple<byte,System.ValueTuple<byte,object>>
	// System.ValueTuple<byte,object>
	// UnityEngine.Events.InvokableCall<byte>
	// UnityEngine.Events.InvokableCall<float>
	// UnityEngine.Events.UnityAction<byte>
	// UnityEngine.Events.UnityAction<float>
	// UnityEngine.Events.UnityEvent<byte>
	// UnityEngine.Events.UnityEvent<float>
	// }}

	public void RefMethods()
	{
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Show.<PlayAn>d__2>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Show.<PlayAn>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,GameDataManager.<Init>d__8>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,GameDataManager.<Init>d__8&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YooAsset.OperationAwaiter,AudioManager.<PlayMusic>d__9>(YooAsset.OperationAwaiter&,AudioManager.<PlayMusic>d__9&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YooAsset.OperationAwaiter,AudioManager.<PlaySound>d__11>(YooAsset.OperationAwaiter&,AudioManager.<PlaySound>d__11&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YooAsset.OperationAwaiter,AudioManager.<PlaySoundAt>d__13>(YooAsset.OperationAwaiter&,AudioManager.<PlaySoundAt>d__13&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted<YooAsset.OperationAwaiter,UIManager.<SetCanvas>d__6>(YooAsset.OperationAwaiter&,UIManager.<SetCanvas>d__6&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<System.Runtime.CompilerServices.TaskAwaiter<object>,JsonManager.<LoadData>d__5<object>>(System.Runtime.CompilerServices.TaskAwaiter<object>&,JsonManager.<LoadData>d__5<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.AwaitUnsafeOnCompleted<YooAsset.OperationAwaiter,UIManager.<ShowPanel>d__7<object>>(YooAsset.OperationAwaiter&,UIManager.<ShowPanel>d__7<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<AudioManager.<PlayMusic>d__10>(AudioManager.<PlayMusic>d__10&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<AudioManager.<PlayMusic>d__9>(AudioManager.<PlayMusic>d__9&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<AudioManager.<PlaySound>d__11>(AudioManager.<PlaySound>d__11&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<AudioManager.<PlaySound>d__12>(AudioManager.<PlaySound>d__12&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<AudioManager.<PlaySoundAt>d__13>(AudioManager.<PlaySoundAt>d__13&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<AudioManager.<PlaySoundAt>d__14>(AudioManager.<PlaySoundAt>d__14&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<GameDataManager.<Init>d__8>(GameDataManager.<Init>d__8&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<Show.<PlayAn>d__2>(Show.<PlayAn>d__2&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder.Start<UIManager.<SetCanvas>d__6>(UIManager.<SetCanvas>d__6&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<JsonManager.<LoadData>d__5<object>>(JsonManager.<LoadData>d__5<object>&)
		// System.Void Cysharp.Threading.Tasks.CompilerServices.AsyncUniTaskMethodBuilder<object>.Start<UIManager.<ShowPanel>d__7<object>>(UIManager.<ShowPanel>d__7<object>&)
		// object LitJson.JsonMapper.ToObject<object>(string)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,InnerSettingPanel.<>c.<<Start>b__6_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,InnerSettingPanel.<>c.<<Start>b__6_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,InnerSettingPanel.<>c.<<Start>b__6_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,InnerSettingPanel.<>c.<<Start>b__6_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,InnerSettingPanel.<>c.<<Start>b__6_2>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,InnerSettingPanel.<>c.<<Start>b__6_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,InnerSettingPanel.<>c.<<Start>b__6_3>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,InnerSettingPanel.<>c.<<Start>b__6_3>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,InnerSettingPanel.<>c.<<Start>b__6_6>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,InnerSettingPanel.<>c.<<Start>b__6_6>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<>c.<<PlayerWin>b__25_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<>c.<<PlayerWin>b__25_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<AttackDamage>d__10>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<AttackDamage>d__10&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<CastQ>d__11>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<CastQ>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<CastT>d__20>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<CastT>d__20&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<DeathSound>d__22>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<DeathSound>d__22&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<EDamage>d__14>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<EDamage>d__14&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<InR>d__16>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<InR>d__16&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<OutR>d__17>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<OutR>d__17&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<PlayerWin>d__25>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<PlayerWin>d__25&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<QDamage>d__12>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<QDamage>d__12&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Jax.<WinSound>d__24>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Jax.<WinSound>d__24&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LevelItem.<<Start>b__5_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LevelItem.<<Start>b__5_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LevelItem.<<Start>b__5_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LevelItem.<<Start>b__5_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LevelSelectPanel.<>c.<<Start>b__4_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LevelSelectPanel.<>c.<<Start>b__4_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LoginPanel.<<Start>b__6_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LoginPanel.<<Start>b__6_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LoginPanel.<<Start>b__6_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LoginPanel.<<Start>b__6_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LoginPanel.<<Start>b__6_2>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LoginPanel.<<Start>b__6_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LoginPanel.<>c.<<Login>b__7_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LoginPanel.<>c.<<Login>b__7_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,LoginPanel.<>c.<<Start>b__6_3>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,LoginPanel.<>c.<<Start>b__6_3>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Main.<Start>d__0>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Main.<Start>d__0&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,RegisterPanel.<<Start>b__5_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,RegisterPanel.<<Start>b__5_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,RegisterPanel.<>c.<<Start>b__5_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,RegisterPanel.<>c.<<Start>b__5_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,SettingPanel.<>c.<<Start>b__5_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,SettingPanel.<>c.<<Start>b__5_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,SettingPanel.<>c.<<Start>b__5_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,SettingPanel.<>c.<<Start>b__5_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,SettingPanel.<>c.<<Start>b__5_2>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,SettingPanel.<>c.<<Start>b__5_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Show.<Start>d__1>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Show.<Start>d__1&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,StartPanel.<>c.<<Start>b__3_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,StartPanel.<>c.<<Start>b__3_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,StartPanel.<>c.<<Start>b__3_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,StartPanel.<>c.<<Start>b__3_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,StartPanel.<>c.<<Start>b__3_2>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,StartPanel.<>c.<<Start>b__3_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,TipPanel.<>c.<<Start>b__2_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,TipPanel.<>c.<<Start>b__2_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<>c.<<EnemyWin>b__24_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<>c.<<EnemyWin>b__24_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<AttackDamage>d__19>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<AttackDamage>d__19&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<CastR>d__12>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<CastR>d__12&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<CastT>d__14>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<CastT>d__14&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<DeathSound>d__21>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<DeathSound>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<EDamage1>d__10>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<EDamage1>d__10&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<EDamage2>d__11>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<EDamage2>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<EnemyWin>d__24>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<EnemyWin>d__24&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<QDamage>d__8>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<QDamage>d__8&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter,Volibear.<WinSound>d__23>(Cysharp.Threading.Tasks.UniTask.Awaiter&,Volibear.<WinSound>d__23&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,GamePanel.<Update>d__11>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,GamePanel.<Update>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,InnerSettingPanel.<>c.<<Start>b__6_6>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,InnerSettingPanel.<>c.<<Start>b__6_6>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Jax.<>c.<<PlayerWin>b__25_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Jax.<>c.<<PlayerWin>b__25_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,LevelItem.<<Start>b__5_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,LevelItem.<<Start>b__5_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,LevelSelectPanel.<>c.<<Start>b__4_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,LevelSelectPanel.<>c.<<Start>b__4_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,LoginPanel.<>c.<<Login>b__7_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,LoginPanel.<>c.<<Login>b__7_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,LoginPanel.<>c.<<Start>b__6_3>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,LoginPanel.<>c.<<Start>b__6_3>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,LoginPanel.<Login>d__7>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,LoginPanel.<Login>d__7&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Main.<Start>d__0>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Main.<Start>d__0&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,RegisterPanel.<>c.<<Start>b__5_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,RegisterPanel.<>c.<<Start>b__5_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,RegisterPanel.<Register>d__6>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,RegisterPanel.<Register>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,StartPanel.<>c.<<Start>b__3_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,StartPanel.<>c.<<Start>b__3_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,StartPanel.<>c.<<Start>b__3_1>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,StartPanel.<>c.<<Start>b__3_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.UniTask.Awaiter<object>,Volibear.<>c.<<EnemyWin>b__24_0>d>(Cysharp.Threading.Tasks.UniTask.Awaiter<object>&,Volibear.<>c.<<EnemyWin>b__24_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.YieldAwaitable.Awaiter,Jax.<CastQ>d__11>(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter&,Jax.<CastQ>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.YieldAwaitable.Awaiter,Jax.<UpdateCD>d__6>(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter&,Jax.<UpdateCD>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<Cysharp.Threading.Tasks.YieldAwaitable.Awaiter,Volibear.<ScaleTo>d__15>(Cysharp.Threading.Tasks.YieldAwaitable.Awaiter&,Volibear.<ScaleTo>d__15&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.AwaitUnsafeOnCompleted<YooAsset.OperationAwaiter,LevelSelectPanel.<Start>d__4>(YooAsset.OperationAwaiter&,LevelSelectPanel.<Start>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<GamePanel.<Update>d__11>(GamePanel.<Update>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<InnerSettingPanel.<>c.<<Start>b__6_0>d>(InnerSettingPanel.<>c.<<Start>b__6_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<InnerSettingPanel.<>c.<<Start>b__6_1>d>(InnerSettingPanel.<>c.<<Start>b__6_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<InnerSettingPanel.<>c.<<Start>b__6_2>d>(InnerSettingPanel.<>c.<<Start>b__6_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<InnerSettingPanel.<>c.<<Start>b__6_3>d>(InnerSettingPanel.<>c.<<Start>b__6_3>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<InnerSettingPanel.<>c.<<Start>b__6_6>d>(InnerSettingPanel.<>c.<<Start>b__6_6>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<InnerSettingPanel.<Start>d__6>(InnerSettingPanel.<Start>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<>c.<<PlayerWin>b__25_0>d>(Jax.<>c.<<PlayerWin>b__25_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<AttackDamage>d__10>(Jax.<AttackDamage>d__10&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<CastQ>d__11>(Jax.<CastQ>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<CastT>d__20>(Jax.<CastT>d__20&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<DeathSound>d__22>(Jax.<DeathSound>d__22&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<EDamage>d__14>(Jax.<EDamage>d__14&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<InR>d__16>(Jax.<InR>d__16&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<OutR>d__17>(Jax.<OutR>d__17&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<PlayerWin>d__25>(Jax.<PlayerWin>d__25&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<QDamage>d__12>(Jax.<QDamage>d__12&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<RDamage>d__19>(Jax.<RDamage>d__19&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<TDamage>d__21>(Jax.<TDamage>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<UpdateCD>d__6>(Jax.<UpdateCD>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Jax.<WinSound>d__24>(Jax.<WinSound>d__24&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LevelItem.<<Start>b__5_0>d>(LevelItem.<<Start>b__5_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LevelItem.<<Start>b__5_1>d>(LevelItem.<<Start>b__5_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LevelItem.<Start>d__5>(LevelItem.<Start>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LevelSelectPanel.<>c.<<Start>b__4_0>d>(LevelSelectPanel.<>c.<<Start>b__4_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LevelSelectPanel.<Start>d__4>(LevelSelectPanel.<Start>d__4&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LoginPanel.<<Start>b__6_0>d>(LoginPanel.<<Start>b__6_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LoginPanel.<<Start>b__6_1>d>(LoginPanel.<<Start>b__6_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LoginPanel.<<Start>b__6_2>d>(LoginPanel.<<Start>b__6_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LoginPanel.<>c.<<Login>b__7_1>d>(LoginPanel.<>c.<<Login>b__7_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LoginPanel.<>c.<<Start>b__6_3>d>(LoginPanel.<>c.<<Start>b__6_3>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LoginPanel.<Login>d__7>(LoginPanel.<Login>d__7&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<LoginPanel.<Start>d__6>(LoginPanel.<Start>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Main.<Start>d__0>(Main.<Start>d__0&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<RegisterPanel.<<Start>b__5_0>d>(RegisterPanel.<<Start>b__5_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<RegisterPanel.<>c.<<Start>b__5_1>d>(RegisterPanel.<>c.<<Start>b__5_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<RegisterPanel.<Register>d__6>(RegisterPanel.<Register>d__6&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<SettingPanel.<>c.<<Start>b__5_0>d>(SettingPanel.<>c.<<Start>b__5_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<SettingPanel.<>c.<<Start>b__5_1>d>(SettingPanel.<>c.<<Start>b__5_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<SettingPanel.<>c.<<Start>b__5_2>d>(SettingPanel.<>c.<<Start>b__5_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<SettingPanel.<Start>d__5>(SettingPanel.<Start>d__5&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Show.<Start>d__1>(Show.<Start>d__1&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<StartPanel.<>c.<<Start>b__3_0>d>(StartPanel.<>c.<<Start>b__3_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<StartPanel.<>c.<<Start>b__3_1>d>(StartPanel.<>c.<<Start>b__3_1>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<StartPanel.<>c.<<Start>b__3_2>d>(StartPanel.<>c.<<Start>b__3_2>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<StartPanel.<Start>d__3>(StartPanel.<Start>d__3&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<TipPanel.<>c.<<Start>b__2_0>d>(TipPanel.<>c.<<Start>b__2_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<>c.<<EnemyWin>b__24_0>d>(Volibear.<>c.<<EnemyWin>b__24_0>d&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<AttackDamage>d__19>(Volibear.<AttackDamage>d__19&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<CastR>d__12>(Volibear.<CastR>d__12&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<CastT>d__14>(Volibear.<CastT>d__14&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<DeathSound>d__21>(Volibear.<DeathSound>d__21&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<EDamage1>d__10>(Volibear.<EDamage1>d__10&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<EDamage2>d__11>(Volibear.<EDamage2>d__11&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<EnemyWin>d__24>(Volibear.<EnemyWin>d__24&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<QDamage>d__8>(Volibear.<QDamage>d__8&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<RDamage>d__13>(Volibear.<RDamage>d__13&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<ScaleTo>d__15>(Volibear.<ScaleTo>d__15&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<TDamage>d__16>(Volibear.<TDamage>d__16&)
		// System.Void System.Runtime.CompilerServices.AsyncVoidMethodBuilder.Start<Volibear.<WinSound>d__23>(Volibear.<WinSound>d__23&)
		// object UnityEngine.Component.GetComponent<object>()
		// object UnityEngine.GameObject.AddComponent<object>()
		// object UnityEngine.GameObject.GetComponent<object>()
		// YooAsset.AssetHandle YooAsset.ResourcePackage.LoadAssetAsync<object>(string,uint)
	}
}