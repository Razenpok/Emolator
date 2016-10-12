﻿using System;

namespace Emolator
{
    public partial class Cpu
    {
        private Action<Cpu, OperationData>[] operations = {
            Brk, Ora, Nop, Nop, Nop, Ora, Asl, Nop, Php, Ora, Asl, Nop, Nop, Ora, Asl, Nop,
            Bpl, Ora, Nop, Nop, Nop, Ora, Asl, Nop, Clc, Ora, Nop, Nop, Nop, Ora, Asl, Nop,
            Jsr, And, Nop, Nop, Bit, And, Rol, Nop, Plp, And, Rol, Nop, Bit, And, Rol, Nop,
            Bmi, And, Nop, Nop, Nop, And, Rol, Nop, Sec, And, Nop, Nop, Nop, And, Rol, Nop,
            Rti, Eor, Nop, Nop, Nop, Eor, Lsr, Nop, Pha, Eor, Lsr, Nop, Jmp, Eor, Lsr, Nop,
            Bvc, Eor, Nop, Nop, Nop, Eor, Lsr, Nop, Cli, Eor, Nop, Nop, Nop, Eor, Lsr, Nop,
            Rts, Adc, Nop, Nop, Nop, Adc, Ror, Nop, Pla, Adc, Ror, Nop, Jmp, Adc, Ror, Nop,
            Bvs, Adc, Nop, Nop, Nop, Adc, Ror, Nop, Sei, Adc, Nop, Nop, Nop, Adc, Ror, Nop,
            Nop, Sta, Nop, Nop, Sty, Sta, Stx, Nop, Dey, Nop, Txa, Nop, Sty, Sta, Stx, Nop,
            Bcc, Sta, Nop, Nop, Sty, Sta, Stx, Nop, Tya, Sta, Txs, Nop, Nop, Sta, Nop, Nop,
            Ldy, Lda, Ldx, Nop, Ldy, Lda, Ldx, Nop, Tay, Lda, Tax, Nop, Ldy, Lda, Ldx, Nop,
            Bcs, Lda, Nop, Nop, Ldy, Lda, Ldx, Nop, Clv, Lda, Tsx, Nop, Ldy, Lda, Ldx, Nop,
            Cpy, Cmp, Nop, Nop, Cpy, Cmp, Dec, Nop, Iny, Cmp, Dex, Nop, Cpy, Cmp, Dec, Nop,
            Bne, Cmp, Nop, Nop, Nop, Cmp, Dec, Nop, Cld, Cmp, Nop, Nop, Nop, Cmp, Dec, Nop,
            Cpx, Sbc, Nop, Nop, Cpx, Sbc, Inc, Nop, Inx, Sbc, Nop, Nop, Cpx, Sbc, Inc, Nop,
            Beq, Sbc, Nop, Nop, Nop, Sbc, Inc, Nop, Sed, Sbc, Nop, Nop, Nop, Sbc, Inc, Nop
        };

        /// <summary>
        /// ADd with Carry
        /// </summary>
        private static void Adc(Cpu cpu, OperationData data) { }

        /// <summary>
        /// bitwise AND with accumulator
        /// </summary>
        private static void And(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Arithmetic Shift Left
        /// </summary>
        private static void Asl(Cpu cpu, OperationData data) { }

        /// <summary>
        /// test BITs
        /// </summary>
        private static void Bit(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on PLus
        /// </summary>
        private static void Bpl(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on MInus
        /// </summary>
        private static void Bmi(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on oVerflow Clear
        /// </summary>
        private static void Bvc(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on oVerflow Set
        /// </summary>
        private static void Bvs(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on Carry Clear
        /// </summary>
        private static void Bcc(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on Carry Set
        /// </summary>
        private static void Bcs(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on Not Equal
        /// </summary>
        private static void Bne(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Branch on EQual
        /// </summary>
        private static void Beq(Cpu cpu, OperationData data) { }

        /// <summary>
        /// BReaK
        /// </summary>
        private static void Brk(Cpu cpu, OperationData data) { }

        /// <summary>
        /// CoMPare accumulator
        /// </summary>
        private static void Cmp(Cpu cpu, OperationData data) { }

        /// <summary>
        /// ComPare X register
        /// </summary>
        private static void Cpx(Cpu cpu, OperationData data) { }

        /// <summary>
        /// ComPare Y register
        /// </summary>
        private static void Cpy(Cpu cpu, OperationData data) { }

        /// <summary>
        /// DECrement memory
        /// </summary>
        private static void Dec(Cpu cpu, OperationData data) { }

        /// <summary>
        /// bitwise Exclusive OR
        /// </summary>
        private static void Eor(Cpu cpu, OperationData data) { }

        /// <summary>
        /// CLear Carry
        /// </summary>
        private static void Clc(Cpu cpu, OperationData data) { }

        /// <summary>
        /// SEt Carry
        /// </summary>
        private static void Sec(Cpu cpu, OperationData data) { }

        /// <summary>
        /// CLear Interrupt
        /// </summary>
        private static void Cli(Cpu cpu, OperationData data) { }

        /// <summary>
        /// SEt Interrupt
        /// </summary>
        private static void Sei(Cpu cpu, OperationData data) { }

        /// <summary>
        /// CLear oVerflow
        /// </summary>
        private static void Clv(Cpu cpu, OperationData data) { }

        /// <summary>
        /// CLear Decimal
        /// </summary>
        private static void Cld(Cpu cpu, OperationData data) { }

        /// <summary>
        /// SEt Decimal
        /// </summary>
        private static void Sed(Cpu cpu, OperationData data) { }

        /// <summary>
        /// INCrement memory
        /// </summary>
        private static void Inc(Cpu cpu, OperationData data) { }

        /// <summary>
        /// JuMP
        /// </summary>
        private static void Jmp(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Jump to SubRoutine
        /// </summary>
        private static void Jsr(Cpu cpu, OperationData data) { }

        /// <summary>
        /// LoaD Accumulator
        /// </summary>
        private static void Lda(Cpu cpu, OperationData data) { }

        /// <summary>
        /// LoaD X registerSEt Decimal
        /// </summary>
        private static void Ldx(Cpu cpu, OperationData data) { }

        /// <summary>
        /// LoaD Y register
        /// </summary>
        private static void Ldy(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Logical Shift Right
        /// </summary>
        private static void Lsr(Cpu cpu, OperationData data) { }

        /// <summary>
        /// No OPeration
        /// </summary>
        private static void Nop(Cpu cpu, OperationData data) { }

        /// <summary>
        /// bitwise OR with Accumulator
        /// </summary>
        private static void Ora(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Transfer A to X
        /// </summary>
        private static void Tax(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Transfer X to A
        /// </summary>
        private static void Txa(Cpu cpu, OperationData data) { }

        /// <summary>
        /// DEcrement X
        /// </summary>
        private static void Dex(Cpu cpu, OperationData data) { }

        /// <summary>
        /// INcrement X
        /// </summary>
        private static void Inx(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Transfer A to Y
        /// </summary>
        private static void Tay(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Transfer Y to A
        /// </summary>
        private static void Tya(Cpu cpu, OperationData data) { }

        /// <summary>
        /// DEcrement Y
        /// </summary>
        private static void Dey(Cpu cpu, OperationData data) { }

        /// <summary>
        /// INcrement Y
        /// </summary>
        private static void Iny(Cpu cpu, OperationData data) { }

        /// <summary>
        /// ROtate Left
        /// </summary>
        private static void Rol(Cpu cpu, OperationData data) { }

        /// <summary>
        /// ROtate Right
        /// </summary>
        private static void Ror(Cpu cpu, OperationData data) { }

        /// <summary>
        /// ReTurn from Interrupt
        /// </summary>
        private static void Rti(Cpu cpu, OperationData data) { }

        /// <summary>
        /// ReTurn from Subroutine
        /// </summary>
        private static void Rts(Cpu cpu, OperationData data) { }

        /// <summary>
        /// SuBtract with Carry
        /// </summary>
        private static void Sbc(Cpu cpu, OperationData data) { }

        /// <summary>
        /// STore Accumulator
        /// </summary>
        private static void Sta(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Transfer X to Stack ptr
        /// </summary>
        private static void Txs(Cpu cpu, OperationData data) { }

        /// <summary>
        /// Transfer Stack ptr to X
        /// </summary>
        private static void Tsx(Cpu cpu, OperationData data) { }

        /// <summary>
        /// PusH Accumulator
        /// </summary>
        private static void Pha(Cpu cpu, OperationData data) { }

        /// <summary>
        /// PuLl Accumulator
        /// </summary>
        private static void Pla(Cpu cpu, OperationData data) { }

        /// <summary>
        /// PusH Processor status
        /// </summary>
        private static void Php(Cpu cpu, OperationData data) { }

        /// <summary>
        /// PuLl Processor status
        /// </summary>
        private static void Plp(Cpu cpu, OperationData data) { }

        /// <summary>
        /// STore X register
        /// </summary>
        private static void Stx(Cpu cpu, OperationData data) { }

        /// <summary>
        /// STore Y register
        /// </summary>
        private static void Sty(Cpu cpu, OperationData data) { }
    }
}
