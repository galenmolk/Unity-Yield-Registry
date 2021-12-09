# Unity-Yield-Registry
A small yield instruction registry to optimize coroutines.

Usage

```
private IEnumerator DisplayLogo()
{
    yield return YieldRegistry.WaitForSeconds(2f);
    DisplayLogo();
}
```
