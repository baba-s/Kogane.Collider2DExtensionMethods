using System.Collections.Generic;
using UnityEngine;

namespace Kogane
{
    public static class Collider2DExtensionMethods
    {
        public static List<Collider2D> OverlapCollider<T>( this T self ) where T : Collider2D
        {
            return self.OverlapCollider( new() );
        }

        public static List<Collider2D> OverlapCollider<T>
        (
            this T          self,
            ContactFilter2D contactFilter
        ) where T : Collider2D
        {
            var results = new List<Collider2D>();
            Physics2D.OverlapCollider( self, contactFilter, results );
            return results;
        }
    }
}