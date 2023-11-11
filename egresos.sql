SELECT u.Nombre AS NombreUsuario,
       v.Nombre AS NombreVisitante,
       v.Dni AS DniVisitante,
       e.fecha AS FechaEgreso
FROM egresos e
JOIN ingresos i ON e.id_ingreso = i.id_ingreso
JOIN solicitudes s ON i.id_solicitud = s.id_solicitud
JOIN usuarios u ON s.id_usuario = u.id_usuario
JOIN visitantes v ON s.id_visitante = v.id_visitante;
