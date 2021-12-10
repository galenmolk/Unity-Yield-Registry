# Unity Yield Registry
Use this registry to cache your `YieldInstruction` objects, saving you on memory allocation and minimizing your garbage collection.

---
**Example Usages:**

_WaitForSeconds_
```
yield return YieldRegistry.WaitForSeconds(5f);
```
_WaitUntil_
```
yield return YieldRegistry.WaitUntil(() => Input.GetKeyDown(KeyCode.Space));
```
_WaitForEndOfFrame_
```
yield return YieldRegistry.WaitForEndOfFrame;
```
_WaitForFixedUpdate_
```
yield return YieldRegistry.WaitForFixedUpdate;
```
