/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_isspace.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: apinho <apinho@student.42.fr>              +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2016/06/28 14:33:31 by apinho            #+#    #+#             */
/*   Updated: 2016/09/20 16:26:23 by apinho           ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

int	ft_isspace(int c)
{
	if (c == ' ' || c == '\n' || c == '\t' \
		|| c == '\r' || c == '\v' || c == '\f')
		return (1);
	return (0);
}
