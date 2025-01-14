using UnityEngine.SceneManagement;
using CozycatGame.SceneSystem.LoadSceneOperations;

namespace CozycatGame.SceneSystem
{
    public interface ISceneLoader
    {
        LoadSceneOperationHandle LoadAsync(string sceneName, LoadSceneMode loadSceneMode);
        LoadSceneOperationHandle UnloadAsync(string sceneName);
        void Load(string sceneName, LoadSceneMode loadSceneMode);
        void Unload(string sceneName);

        LoadSceneOperation GetLoadSceneOperation(string sceneName, LoadSceneMode loadSceneMode);
        LoadSceneOperation GetUnloadSceneOperation(string sceneName);
    }
}
