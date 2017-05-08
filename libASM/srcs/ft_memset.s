section .text
global _ft_memset

_ft_memset:
		mov		r10, rdi
		cmp		rdi, byte 0
		je		end
		cld
		mov		al, sil
		mov		rcx, rdx
		rep		stosb
		jmp		end

end:
		mov		rax, r10
		ret
		