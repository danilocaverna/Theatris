using System;
[Serializable]
public class FloatVariableArray : IBaseVariable{
    float[] _value;
    public Object value {
        get{
            return (Object) _value;
        }
        set{
            _value = (float[]) value;
        }
    }
}