## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaVirtualFunctions()
       mov       rdi,[rdi+8]
       jmp       qword ptr [749DD24B6AA8]; CleanCode.Executor.GetAreaVirtualFunctions(CleanCode.Shape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaVirtualFunctions(CleanCode.Shape[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rbx
       sub       rsp,10
       vzeroupper
       lea       rbp,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vmovsd    qword ptr [rbp-28],xmm0
       mov       rbx,rdi
       xor       r15d,r15d
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L04
       mov       r13,offset MT_CleanCode.Circle
M01_L00:
       mov       edi,r15d
       mov       rdi,[rbx+rdi*8+10]
       mov       rax,[rdi]
       cmp       rax,r13
       je        short M01_L05
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       vmovaps   xmm1,xmm0
M01_L01:
       vmovsd    xmm0,qword ptr [rbp-28]
       vaddsd    xmm0,xmm0,xmm1
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L03
M01_L02:
       add       rsp,10
       pop       rbx
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L03:
       vmovsd    qword ptr [rbp-28],xmm0
       jmp       short M01_L00
M01_L04:
       vmovsd    xmm0,qword ptr [rbp-28]
       jmp       short M01_L02
M01_L05:
       vmovsd    xmm1,qword ptr [rdi+8]
       vmulsd    xmm1,xmm1,xmm1
       vmulsd    xmm1,xmm1,qword ptr [749DD1C5AF70]
       jmp       short M01_L01
; Total bytes of code 144
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaSwitch()
       mov       rdi,[rdi+10]
       jmp       qword ptr [7B7B674C6B20]; CleanCode.Executor.GetAreaSwitch(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaSwitch(CleanCode.UnionShape[])
       push      rbp
       push      r15
       push      r14
       push      rbx
       sub       rsp,28
       vzeroupper
       lea       rbp,[rsp+40]
       vxorps    xmm0,xmm0,xmm0
       vmovsd    qword ptr [rbp-20],xmm0
       mov       rbx,rdi
       xor       r15d,r15d
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M01_L03
M01_L00:
       mov       eax,r15d
       lea       rax,[rax+rax*2]
       shl       rax,3
       add       rax,10
       add       rax,rbx
       vmovdqu   xmm1,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rsp],xmm1
       mov       rcx,[rax+10]
       mov       [rsp+10],rcx
       call      qword ptr [7B7B674C6B38]; CleanCode.Executor.AreaSwitch(CleanCode.UnionShape)
       vaddsd    xmm0,xmm0,qword ptr [rbp-20]
       inc       r15d
       cmp       r14d,r15d
       jg        short M01_L02
M01_L01:
       add       rsp,28
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L02:
       vmovsd    qword ptr [rbp-20],xmm0
       jmp       short M01_L00
M01_L03:
       vmovsd    xmm0,qword ptr [rbp-20]
       jmp       short M01_L01
; Total bytes of code 122
```
```assembly
; CleanCode.Executor.AreaSwitch(CleanCode.UnionShape)
       push      rbp
       push      rbx
       push      rax
       vzeroupper
       lea       rbp,[rsp+10]
M02_L00:
       vmovsd    xmm0,qword ptr [rbp+18]
       mov       ebx,[rbp+10]
       cmp       ebx,3
       ja        short M02_L02
       mov       edi,ebx
       lea       rax,[7B7B66C6AE60]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M02_L00]
       add       rax,rcx
       jmp       rax
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7B7B66C6AE70]
M02_L01:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
       vmulsd    xmm0,xmm0,qword ptr [rbp+20]
       jmp       short M02_L01
       vmulsd    xmm0,xmm0,qword ptr [rbp+20]
       vmulsd    xmm0,xmm0,qword ptr [7B7B66C6AE78]
       jmp       short M02_L01
       vmulsd    xmm0,xmm0,xmm0
       jmp       short M02_L01
M02_L02:
       mov       rdi,offset MT_CleanCode.ShapeType
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdi,rax
       call      qword ptr [7B7B674C6BF8]
       int       3
; Total bytes of code 123
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaSwitchInline()
       mov       rdi,[rdi+10]
       jmp       qword ptr [7A71E30D6B50]; CleanCode.Executor.GetAreaSwitchInlined(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaSwitchInlined(CleanCode.UnionShape[])
       push      rbp
       push      rbx
       push      rax
       vzeroupper
       lea       rbp,[rsp+10]
M01_L00:
       vxorps    xmm0,xmm0,xmm0
       xor       eax,eax
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jle       short M01_L03
M01_L01:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rdi+rdx*8+10]
       mov       ebx,[rdx]
       vmovsd    xmm1,qword ptr [rdx+8]
       vmovsd    xmm2,qword ptr [rdx+10]
       cmp       ebx,3
       ja        short M01_L04
       mov       edx,ebx
       lea       rsi,[7A71E287AF60]
       mov       esi,[rsi+rdx*4]
       lea       r8,[M01_L00]
       add       rsi,r8
       jmp       rsi
       vmulsd    xmm3,xmm1,xmm2
       vmulsd    xmm3,xmm3,qword ptr [7A71E287AF70]
       jmp       short M01_L02
       vmulsd    xmm3,xmm1,xmm1
M01_L02:
       vaddsd    xmm0,xmm0,xmm3
       inc       eax
       cmp       ecx,eax
       jg        short M01_L01
M01_L03:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm3,xmm3,qword ptr [7A71E287AF78]
       jmp       short M01_L02
       vmulsd    xmm3,xmm1,xmm2
       jmp       short M01_L02
M01_L04:
       mov       rdi,offset MT_CleanCode.ShapeType
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdi,rax
       call      qword ptr [7A71E30D6BF8]
       int       3
; Total bytes of code 159
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaIf()
       mov       rdi,[rdi+10]
       jmp       qword ptr [7CCE072B6B80]; CleanCode.Executor.GetAreaIf(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaIf(CleanCode.UnionShape[])
       push      rbp
       vzeroupper
       mov       rbp,rsp
       vxorps    xmm0,xmm0,xmm0
       xor       eax,eax
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jle       short M01_L03
M01_L00:
       mov       edx,eax
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[rdi+rdx*8+10]
       mov       esi,[rdx]
       vmovsd    xmm1,qword ptr [rdx+8]
       vmovsd    xmm2,qword ptr [rdx+10]
       test      esi,esi
       je        short M01_L05
       cmp       esi,1
       je        short M01_L04
       cmp       esi,3
       jne       short M01_L01
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm3,xmm3,qword ptr [7CCE06A5AE38]
       jmp       short M01_L02
M01_L01:
       cmp       esi,2
       jne       short M01_L06
       vmulsd    xmm3,xmm1,xmm1
M01_L02:
       vaddsd    xmm0,xmm0,xmm3
       inc       eax
       cmp       ecx,eax
       jg        short M01_L00
M01_L03:
       pop       rbp
       ret
M01_L04:
       vmulsd    xmm3,xmm1,xmm2
       vmulsd    xmm3,xmm3,qword ptr [7CCE06A5AE40]
       jmp       short M01_L02
M01_L05:
       vmulsd    xmm3,xmm1,xmm2
       jmp       short M01_L02
M01_L06:
       vxorps    xmm3,xmm3,xmm3
       jmp       short M01_L02
; Total bytes of code 118
```

## .NET 8.0.11 (8.0.11, 8.0.1124.51707), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaTable()
       mov       rdi,[rdi+10]
       jmp       qword ptr [76B97A0D6B50]; CleanCode.Executor.GetAreaTable(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaTable(CleanCode.UnionShape[])
       push      rbp
       vzeroupper
       mov       rbp,rsp
       vxorps    xmm0,xmm0,xmm0
       xor       eax,eax
       mov       ecx,[rdi+8]
       test      ecx,ecx
       jle       short M01_L01
       mov       rdx,767964004268
       mov       rdx,[rdx]
M01_L00:
       mov       esi,eax
       lea       rsi,[rsi+rsi*2]
       lea       rsi,[rdi+rsi*8+10]
       mov       r8d,[rsi]
       vmovsd    xmm1,qword ptr [rsi+8]
       vmovsd    xmm2,qword ptr [rsi+10]
       vmulsd    xmm1,xmm1,xmm2
       mov       rsi,rdx
       cmp       r8d,4
       jae       short M01_L02
       vmulsd    xmm1,xmm1,qword ptr [rsi+r8*8+10]
       vaddsd    xmm0,xmm1,xmm0
       inc       eax
       cmp       ecx,eax
       jg        short M01_L00
M01_L01:
       pop       rbp
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 95
```

