section .text
global _ft_strlen

_ft_strlen:
		push	rdi
		cmp			rdi, byte 0
		je			error
		sub			rcx, rcx
		sub			al, al
		not			rcx
		cld
		repne	scasb
		not			rcx
		dec			rcx
		mov			rax, rcx
		pop			rdi
		ret

error:
		mov			rax, -1
		ret
		