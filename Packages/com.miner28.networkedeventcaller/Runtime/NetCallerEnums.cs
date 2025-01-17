﻿public enum SyncTarget
{
    All,
    Local,
    Others,
    Master,
    NonMaster,
}

public enum Types
{
    Boolean,
    Byte,
    SByte,
    Int16,
    UInt16,
    Int32,
    UInt32,
    Int64,
    UInt64,
    Single,
    Double,
    String,
    Decimal,
    VRCPlayerApi,
    Color,
    Color32,
    Vector2,
    Vector2Int,
    Vector3,
    Vector3Int,
    Vector4,
    Quaternion,
    DateTime,

    //Arrays    
    BooleanA,
    ByteA,
    SByteA,
    Int16A,
    UInt16A,
    Int32A,
    UInt32A,
    Int64A,
    UInt64A,
    SingleA,
    DoubleA,
    DecimalA,
    StringA,
    VRCPlayerApiA,
    ColorA,
    Color32A,
    Vector2A,
    Vector2IntA,
    Vector3A,
    Vector3IntA,
    Vector4A,
    QuaternionA,
    Null,

    //Variable Size
    Int16V = 60,
    Int16VN = 70,
    Int32V = 80,
    Int32VN = 90,
    Int64V = 100,
    Int64VN = 110,
    UInt16V = 120,
    UInt32V = 130,
    UInt64V = 140,
}