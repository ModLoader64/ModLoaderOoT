//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModLoader.OoT.API {
    
    
    public class WrapperHorseData {
        
        [System.Text.Json.Serialization.JsonIgnoreAttribute()]
        private u32 pointer;
        
        public s16 sceneId {get => this._sceneId(); set => this._sceneId(value);}//;
        
        public WrapperVec3s pos {get => this._pos(); set => this._pos(value);}//;
        
        public s16 angle {get => this._angle(); set => this._angle(value);}//;
        
        public WrapperHorseData(u32 pointer) {
           this.pointer = pointer;
        }
        
        public static uint getSize() {
          return 0x0A;
        }
        
        private s16 _sceneId() {
            return Memory.RAM.ReadS16(this.pointer + 0x00);
        }
        
        private void _sceneId(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x00, value);
        }
        
        private WrapperVec3s _pos() {
            return new WrapperVec3s(this.pointer + 0x02);
        }
        
        private void _pos(WrapperVec3s value) {
        }
        
        private s16 _angle() {
            return Memory.RAM.ReadS16(this.pointer + 0x08);
        }
        
        private void _angle(s16 value) {
            Memory.RAM.WriteS16(this.pointer + 0x08, value);
        }
    }
}
