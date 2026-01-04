## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaVirtualFunctions()
       mov       rdi,[rdi+8]
       jmp       qword ptr [78B045E36C10]; CleanCode.Executor.GetAreaVirtualFunctions(CleanCode.Shape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaVirtualFunctions(CleanCode.Shape[])
       push      rbp
       push      r15
       push      r14
       push      rbx
       push      rax
       lea       rbp,[rsp+20]
       vxorps    xmm0,xmm0,xmm0
       vmovsd    qword ptr [rbp-20],xmm0
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M01_L03
       mov       r15,offset MT_CleanCode.Square
       lea       r14,[rdi+10]
       jmp       short M01_L02
M01_L00:
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
M01_L01:
       vmovsd    xmm1,qword ptr [rbp-20]
       vaddsd    xmm1,xmm1,xmm0
       add       r14,8
       dec       ebx
       je        short M01_L04
       vmovsd    qword ptr [rbp-20],xmm1
M01_L02:
       mov       rdi,[r14]
       mov       rax,[rdi]
       cmp       rax,r15
       jne       short M01_L00
       vmovsd    xmm1,qword ptr [rdi+8]
       vmulsd    xmm1,xmm1,xmm1
       vmovaps   xmm0,xmm1
       jmp       short M01_L01
M01_L03:
       vmovsd    xmm1,qword ptr [rbp-20]
M01_L04:
       vmovaps   xmm0,xmm1
       add       rsp,8
       pop       rbx
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 119
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaSwitch()
       mov       rdi,[rdi+10]
       jmp       qword ptr [7EDCD9026B08]; CleanCode.Executor.GetAreaSwitch(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaSwitch(CleanCode.UnionShape[])
       push      rbp
       push      r15
       push      rbx
       sub       rsp,20
       lea       rbp,[rsp+30]
       vxorps    xmm0,xmm0,xmm0
       vmovsd    qword ptr [rbp-18],xmm0
       mov       ebx,[rdi+8]
       test      ebx,ebx
       jle       short M01_L01
       lea       r15,[rdi+10]
M01_L00:
       vmovdqu   xmm1,xmmword ptr [r15]
       vmovdqu   xmmword ptr [rsp],xmm1
       mov       rax,[r15+10]
       mov       [rsp+10],rax
       call      qword ptr [7EDCD9026B20]; CleanCode.Executor.AreaSwitch(CleanCode.UnionShape)
       vaddsd    xmm0,xmm0,qword ptr [rbp-18]
       add       r15,18
       dec       ebx
       je        short M01_L02
       vmovsd    qword ptr [rbp-18],xmm0
       jmp       short M01_L00
M01_L01:
       vmovsd    xmm0,qword ptr [rbp-18]
M01_L02:
       add       rsp,20
       pop       rbx
       pop       r15
       pop       rbp
       ret
; Total bytes of code 92
```
```assembly
; CleanCode.Executor.AreaSwitch(CleanCode.UnionShape)
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
M02_L00:
       mov       ebx,[rbp+10]
       vmovsd    xmm0,qword ptr [rbp+18]
       cmp       ebx,3
       ja        short M02_L02
       mov       edi,ebx
       lea       rax,[7EDCD85AF1D8]
       mov       eax,[rax+rdi*4]
       lea       rcx,[M02_L00]
       add       rax,rcx
       jmp       rax
       vmulsd    xmm0,xmm0,qword ptr [rbp+20]
M02_L01:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
       vmulsd    xmm0,xmm0,xmm0
       vmulsd    xmm0,xmm0,qword ptr [7EDCD85AF1E8]
       jmp       short M02_L01
       vmulsd    xmm0,xmm0,xmm0
       jmp       short M02_L01
       vmulsd    xmm0,xmm0,qword ptr [rbp+20]
       vmulsd    xmm0,xmm0,qword ptr [7EDCD85AF1F0]
       jmp       short M02_L01
M02_L02:
       mov       rdi,offset MT_CleanCode.ShapeType
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdi,rax
       call      qword ptr [7EDCD9026B38]
       int       3
; Total bytes of code 120
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaSwitchInline()
       mov       rdi,[rdi+10]
       jmp       qword ptr [73AAB4846C10]; CleanCode.Executor.GetAreaSwitchInlined(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaSwitchInlined(CleanCode.UnionShape[])
       push      rbp
       push      rbx
       push      rax
       lea       rbp,[rsp+10]
M01_L00:
       vxorps    xmm0,xmm0,xmm0
       mov       eax,[rdi+8]
       test      eax,eax
       jle       short M01_L03
       add       rdi,10
       jmp       short M01_L02
       vmulsd    xmm1,xmm1,xmm2
       vmulsd    xmm1,xmm1,qword ptr [73AAB3DCF2D8]
       jmp       short M01_L01
       vmulsd    xmm1,xmm1,xmm2
M01_L01:
       vaddsd    xmm0,xmm0,xmm1
       add       rdi,18
       dec       eax
       je        short M01_L03
M01_L02:
       mov       ebx,[rdi]
       vmovsd    xmm1,qword ptr [rdi+8]
       vmovsd    xmm2,qword ptr [rdi+10]
       cmp       ebx,3
       ja        short M01_L04
       mov       ecx,ebx
       lea       rdx,[73AAB3DCF2E0]
       mov       edx,[rdx+rcx*4]
       lea       rsi,[M01_L00]
       add       rdx,rsi
       jmp       rdx
       vmulsd    xmm1,xmm1,xmm1
       jmp       short M01_L01
       vmulsd    xmm1,xmm1,xmm1
       vmulsd    xmm1,xmm1,qword ptr [73AAB3DCF2F0]
       jmp       short M01_L01
M01_L03:
       add       rsp,8
       pop       rbx
       pop       rbp
       ret
M01_L04:
       mov       rdi,offset MT_CleanCode.ShapeType
       call      CORINFO_HELP_NEWSFAST
       mov       [rax+8],ebx
       mov       rdi,rax
       call      qword ptr [73AAB4846C40]
       int       3
; Total bytes of code 151
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaIf()
       mov       rdi,[rdi+10]
       jmp       qword ptr [7BA2B8016B08]; CleanCode.Executor.GetAreaIf(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaIf(CleanCode.UnionShape[])
       push      rbp
       mov       rbp,rsp
       vxorps    xmm0,xmm0,xmm0
       mov       eax,[rdi+8]
       test      eax,eax
       jle       short M01_L05
       add       rdi,10
       jmp       short M01_L02
       nop       word ptr [rax+rax]
M01_L00:
       vmulsd    xmm3,xmm1,xmm2
M01_L01:
       vaddsd    xmm0,xmm0,xmm3
       add       rdi,18
       dec       eax
       je        short M01_L05
M01_L02:
       mov       ecx,[rdi]
       vmovsd    xmm1,qword ptr [rdi+8]
       vmovsd    xmm2,qword ptr [rdi+10]
       test      ecx,ecx
       je        short M01_L00
       cmp       ecx,1
       je        short M01_L04
       cmp       ecx,3
       je        short M01_L03
       cmp       ecx,2
       jne       short M01_L06
       vmulsd    xmm3,xmm1,xmm1
       jmp       short M01_L01
M01_L03:
       vmulsd    xmm3,xmm1,xmm1
       vmulsd    xmm3,xmm3,qword ptr [7BA2B759F1E0]
       jmp       short M01_L01
M01_L04:
       vmulsd    xmm3,xmm1,xmm2
       vmulsd    xmm3,xmm3,qword ptr [7BA2B759F1E8]
       jmp       short M01_L01
M01_L05:
       pop       rbp
       ret
M01_L06:
       vxorps    xmm3,xmm3,xmm3
       jmp       short M01_L01
; Total bytes of code 121
```

## .NET 10.0.0 (10.0.0, 10.0.25.52411), X64 RyuJIT x86-64-v3 (Job: DefaultJob)

```assembly
; CleanCode.ExecutorBenchmark.GetAreaTable()
       mov       rdi,[rdi+10]
       jmp       qword ptr [7CFD78646C10]; CleanCode.Executor.GetAreaTable(CleanCode.UnionShape[])
; Total bytes of code 10
```
```assembly
; CleanCode.Executor.GetAreaTable(CleanCode.UnionShape[])
       push      rbp
       mov       rbp,rsp
       vxorps    xmm0,xmm0,xmm0
       mov       eax,[rdi+8]
       test      eax,eax
       jle       short M01_L01
       mov       rcx,7CFC7A001378
       mov       rcx,[rcx]
       add       rdi,10
M01_L00:
       mov       edx,[rdi]
       vmovsd    xmm1,qword ptr [rdi+8]
       vmovsd    xmm2,qword ptr [rdi+10]
       vmulsd    xmm1,xmm1,xmm2
       cmp       edx,4
       jae       short M01_L02
       vmulsd    xmm1,xmm1,qword ptr [rcx+rdx*8+10]
       vaddsd    xmm0,xmm1,xmm0
       add       rdi,18
       dec       eax
       jne       short M01_L00
M01_L01:
       pop       rbp
       ret
M01_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 79
```

