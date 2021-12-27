# all test passed.
# this thing is used in Brawl Stars battles.
# feel free to use it

class BitStream:
    def __init__(self, buff=None):
        if buff is None: self.buffer = bytearray(b'')
        else: self.buffer = buff
        self.bitIndex = 0
        self.offset = 0
    
    def readBit(self):
        if self.offset > len(self.buffer):
            print("Out of range!")
            return 0
        value = (self.buffer[self.offset] >> self.bitIndex) & 1
        self.bitIndex += 1
        if (self.bitIndex == 8):
            self.bitIndex = 0
            self.offset += 1
        return value
    
    def readBytes(self, length):
        data = []
        i = 0
        while i < length:
            value = 0
            p = 0
            while p < 8 and i < length:
                value |= self.readBit() << p
                i += 1
                p += 1
            data.append(value)
        return bytes(data)
    
    def readPositiveInt(self, bitsCount):
        data = self.readBytes(bitsCount)
        return int.from_bytes(data, "little")
    
    def readInt(self, bitsCount):
        v2 = 2 * self.readPositiveInt(1) - 1
        return v2 * self.readPositiveInt(bitsCount)
    
    def readPositiveVIntMax255(self):
        v2 = self.readPositiveInt(3)
        return self.readPositiveInt(v2)
    
    def writeBit(self, data):
        if (self.bitIndex == 0):
            self.offset += 1
            self.buffer += bytearray(b'\xff');
        
        value = self.buffer[self.offset - 1]
        value &= ~(1 << self.bitIndex)
        value |= (data << self.bitIndex)
        self.buffer[self.offset - 1] = value
        
        self.bitIndex = (self.bitIndex + 1) % 8
        

    def dectobin(self, num, bitsCount):
        binary = bin(num)
        bitterly = binary[2:]
        bits = []
        for b in bitterly:
            if b == '0': bits.append(0)
            else: bits.append(1)
        return bits[::-1]
    
    def writeBits(self, bits, count):
        i = 0
        position = 0
        while i < count:
            value = 0
            
            p = 0
            while p < 8 and i < count:
                value = (bits[position] >> p) & 1
                self.writeBit(value)
                p += 1
                i += 1
            position += 1
    
    def writePositiveInt(self, value, bitsCount):
        self.writeBits(value.to_bytes(4, byteorder='little'), bitsCount)

    def writeInt(self, value, bitsCount):
        val = value
        if val <= -1:
            self.writePositiveInt(0, 1)
            val = -value
        elif val >= 0:
            self.writePositiveInt(1, 1)
            val = value
        self.writePositiveInt(val, bitsCount)
    
    def writePositiveVInt(self, value, count):
        v3 = 1
        v7 = value
        
        if v7 != 0:
            if (v7 < 1):
                v3 = 0
            else:
                v8 = v7
                v3 = 0
                
                v3 += 1
                v8 >>= 1
                
                while (v8 != 0):
                    v3 += 1
                    v8 >>= 1
        self.writePositiveInt(v3 - 1, count)
        self.writePositiveInt(v7, v3)
