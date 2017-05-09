﻿using System.Runtime.InteropServices;
using OpenTK;
using OpenTK.Graphics.OpenGL4;
using Vector3 = OpenTK.Vector3;

namespace BoTK.Editor.Common {
  [StructLayout(LayoutKind.Sequential,Pack=1)]
  public struct ColoredVertex {
    public static ColoredVertex Create(Vector3 Position, Vector4 Color) {
      return new ColoredVertex {
        X = Position.X,
        Y = Position.Y,
        Z = Position.Z,

        R = Color.X,
        G = Color.Y,
        B = Color.Z,
        A = Color.W
      };
    }

    [AttributeSlotMeta(0, "Position", VertexAttribPointerType.Float, 3)]
    public float X, Y, Z;

    [AttributeSlotMeta(1, "Color", VertexAttribPointerType.Float, 4)]
    public float R, G, B, A;
  }
}