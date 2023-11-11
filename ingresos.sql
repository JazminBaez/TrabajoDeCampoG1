SELECT u.Nombre AS NombreUsuario,
       v.Nombre AS NombreVisitante,
       v.Dni AS DniVisitante,
       i.fecha AS FechaIngreso
FROM ingresos i
JOIN solicitudes s ON i.id_solicitud = s.id_solicitud
JOIN usuarios u ON s.id_usuario = u.id_usuario
JOIN visitantes v ON s.id_visitante = v.id_visitante;
