-- ============================================================
--  SmartCorporate Database — Sample Data Insertion
--  Project 13: The Smart Corporate Workspace & Resource Hub
--  Group 145 | TA: Nour Elhoda Khaled | IS211 Spring 2026
-- ============================================================

USE SmartCorporate;
GO

-- ============================================================
--  1. HUB
--     hub_id auto-generated: 1, 2, 3, 4, 5
--     No dependencies — insert first
-- ============================================================
INSERT INTO Hub (district_location, architectural_layout) VALUES
('Maadi, Cairo',        'Open Floor Glass Tower'),
('Zamalek, Cairo',      'Heritage Renovated Building'),
('New Cairo, Cairo',    'Modern Smart Campus'),
('Sheikh Zayed, Giza',  'Mixed-Use Commercial Complex'),
('Downtown, Cairo',     'Co-working High-Rise');

-- ============================================================
--  2. WORKSPACE
--     workspace_id auto-generated: 1 → 13
--     hub_id references Hub
-- ============================================================
INSERT INTO Workspace (hub_id, type, rate) VALUES
-- Hub 1: Maadi
(1, 'Private Glass Office', 150.00),   -- workspace_id = 1
(1, 'Open Desk',             50.00),   -- workspace_id = 2
(1, 'Meeting Pod',           90.00),   -- workspace_id = 3
-- Hub 2: Zamalek
(2, 'Private Glass Office', 170.00),   -- workspace_id = 4
(2, 'Open Desk',             60.00),   -- workspace_id = 5
(2, 'Meeting Pod',          100.00),   -- workspace_id = 6
-- Hub 3: New Cairo
(3, 'Private Glass Office', 200.00),   -- workspace_id = 7
(3, 'Open Desk',             70.00),   -- workspace_id = 8
(3, 'Meeting Pod',          120.00),   -- workspace_id = 9
-- Hub 4: Sheikh Zayed
(4, 'Private Glass Office', 180.00),   -- workspace_id = 10
(4, 'Open Desk',             55.00),   -- workspace_id = 11
-- Hub 5: Downtown
(5, 'Open Desk',             45.00),   -- workspace_id = 12
(5, 'Meeting Pod',           80.00);   -- workspace_id = 13

-- ============================================================
--  3. MEMBER
--     member_id auto-generated: 1 → 10
--     No dependencies
-- ============================================================
INSERT INTO Member (name, corporate_affiliation) VALUES
('Ahmed Hassan',    'TechCorp Egypt'),       -- member_id = 1
('Sara Mohamed',    'StartUp Hub Ltd'),      -- member_id = 2
('Omar Khalid',     'Delta Consulting'),     -- member_id = 3
('Nour Ali',        'Freelance Designer'),   -- member_id = 4
('Youssef Mahmoud', 'Cairo Digital Agency'), -- member_id = 5
('Mariam Samir',    'NileSoft Solutions'),   -- member_id = 6
('Karim Adel',      'TechCorp Egypt'),       -- member_id = 7
('Dina Tarek',      'Global Finance Co'),    -- member_id = 8
('Mostafa Ibrahim', 'StartUp Hub Ltd'),      -- member_id = 9
('Layla Fawzy',     'Delta Consulting');     -- member_id = 10

-- ============================================================
--  4. EQUIPMENT
--     equipment_id auto-generated: 1 → 8
--     No dependencies
-- ============================================================
INSERT INTO Equipment (type) VALUES
('HD Projector'),               -- equipment_id = 1
('Ergonomic Standing Desk'),    -- equipment_id = 2
('Dual Monitor Setup'),         -- equipment_id = 3
('Video Conferencing System'),  -- equipment_id = 4
('Whiteboard'),                 -- equipment_id = 5
('High-Speed WiFi Extender'),   -- equipment_id = 6
('4K Smart TV'),                -- equipment_id = 7
('Noise-Cancelling Headset');   -- equipment_id = 8

-- ============================================================
--  5. RESERVATION
--     reservation_id auto-generated
--     member_id    → Member
--     workspace_id → Workspace
--     equipment_id → Equipment
--
--  Quick Reference:
--  Members  : 1=Ahmed, 2=Sara, 3=Omar, 4=Nour, 5=Youssef,
--             6=Mariam, 7=Karim, 8=Dina, 9=Mostafa, 10=Layla
--  Workspaces: 1=Maadi-Office,  2=Maadi-Desk,    3=Maadi-Pod
--              4=Zamalek-Office,5=Zamalek-Desk,  6=Zamalek-Pod
--              7=NewCairo-Off,  8=NewCairo-Desk, 9=NewCairo-Pod
--              10=ShZayed-Off, 11=ShZayed-Desk
--              12=Downtown-Desk,13=Downtown-Pod
--  Equipment : 1=Projector, 2=StandingDesk, 3=DualMonitor,
--              4=VideoConf, 5=Whiteboard,   6=WiFi,
--              7=4KTV,      8=Headset
-- ============================================================

-- ── April 2026 — Last Month (15 reservations) ──
INSERT INTO Reservation (member_id, workspace_id, equipment_id, rate, reservation_date) VALUES
(1,  1,  1,  150.00, '2026-04-01 09:00:00'),  -- Ahmed   @ Maadi Office       + Projector
(2,  5,  2,   60.00, '2026-04-02 10:00:00'),  -- Sara    @ Zamalek Desk       + Standing Desk
(3,  9,  4,  120.00, '2026-04-03 11:00:00'),  -- Omar    @ NewCairo Pod       + Video Conf
(4,  7,  1,  200.00, '2026-04-05 08:00:00'),  -- Nour    @ NewCairo Office    + Projector
(5,  3,  5,   90.00, '2026-04-07 13:00:00'),  -- Youssef @ Maadi Pod          + Whiteboard
(6,  10, 3,  180.00, '2026-04-08 09:00:00'),  -- Mariam  @ SheikhZayed Office + Dual Monitor
(7,  2,  8,   50.00, '2026-04-10 14:00:00'),  -- Karim   @ Maadi Desk         + Headset
(8,  6,  4,  100.00, '2026-04-12 10:00:00'),  -- Dina    @ Zamalek Pod        + Video Conf
(9,  12, 6,   45.00, '2026-04-14 09:00:00'),  -- Mostafa @ Downtown Desk      + WiFi
(10, 4,  7,  170.00, '2026-04-15 11:00:00'),  -- Layla   @ Zamalek Office     + 4K TV
(1,  8,  6,   70.00, '2026-04-17 09:00:00'),  -- Ahmed   @ NewCairo Desk      + WiFi
(2,  13, 5,   80.00, '2026-04-18 15:00:00'),  -- Sara    @ Downtown Pod       + Whiteboard
(3,  11, 2,   55.00, '2026-04-20 10:00:00'),  -- Omar    @ SheikhZayed Desk   + Standing Desk
(5,  1,  7,  150.00, '2026-04-22 08:00:00'),  -- Youssef @ Maadi Office       + 4K TV
(6,  9,  4,  120.00, '2026-04-25 13:00:00');  -- Mariam  @ NewCairo Pod       + Video Conf

-- ── May 2026 — Current Month (5 reservations) ──
INSERT INTO Reservation (member_id, workspace_id, equipment_id, rate, reservation_date) VALUES
(1,  7,  3,  200.00, '2026-05-01 09:00:00'),  -- Ahmed @ NewCairo Office   + Dual Monitor
(3,  3,  4,   90.00, '2026-05-02 10:00:00'),  -- Omar  @ Maadi Pod         + Video Conf
(7,  10, 2,  180.00, '2026-05-03 09:00:00'),  -- Karim @ SheikhZayed Off   + Standing Desk
(8,  5,  6,   60.00, '2026-05-04 11:00:00'),  -- Dina  @ Zamalek Desk      + WiFi
(10, 13, 5,   80.00, '2026-05-05 14:00:00');  -- Layla @ Downtown Pod      + Whiteboard

-- ============================================================
--  VERIFICATION QUERIES
--  Run these after insertion to confirm everything is correct
-- ============================================================

-- 1. Row counts — should show: Hub=5, Workspace=13, Member=10, Equipment=8, Reservation=20
SELECT 'Hub'       AS TableName, COUNT(*) AS 'RowCount' FROM Hub       UNION ALL
SELECT 'Workspace',              COUNT(*)             FROM Workspace  UNION ALL
SELECT 'Member',                 COUNT(*)             FROM Member     UNION ALL
SELECT 'Equipment',              COUNT(*)             FROM Equipment  UNION ALL
SELECT 'Reservation',            COUNT(*)             FROM Reservation;

-- 2. Full reservation details with all 4 joins
SELECT
    r.reservation_id,
    m.name                  AS member_name,
    m.corporate_affiliation,
    h.district_location     AS hub,
    w.type                  AS workspace_type,
    e.type                  AS equipment_type,
    r.rate,
    r.reservation_date
FROM  Reservation r
JOIN  Member      m ON r.member_id    = m.member_id
JOIN  Workspace   w ON r.workspace_id = w.workspace_id
JOIN  Hub         h ON w.hub_id       = h.hub_id
JOIN  Equipment   e ON r.equipment_id = e.equipment_id
ORDER BY r.reservation_date;

-- 3. Inquiry 1 — Most popular workspace type by reservation count
SELECT TOP 1
    w.type              AS workspace_type,
    COUNT(r.reservation_id) AS total_reservations
FROM  Reservation r
JOIN  Workspace   w ON r.workspace_id = w.workspace_id
GROUP BY w.type
ORDER BY total_reservations DESC;

-- 4. Inquiry 2 — Hubs with NO reservations in April 2026
SELECT
    h.hub_id,
    h.district_location
FROM  Hub h
LEFT JOIN Workspace   w ON h.hub_id       = w.hub_id
LEFT JOIN Reservation r ON w.workspace_id = r.workspace_id
    AND MONTH(r.reservation_date) = 4
    AND YEAR(r.reservation_date)  = 2026
WHERE r.reservation_id IS NULL;

-- 5. Inquiry 3 — Member who used the most variety of different equipment in April 2026
SELECT TOP 1
    m.name,
    COUNT(DISTINCT r.equipment_id) AS equipment_variety
FROM  Reservation r
JOIN  Member      m ON r.member_id = m.member_id
WHERE MONTH(r.reservation_date) = 4
  AND YEAR(r.reservation_date)  = 2026
GROUP BY m.name
ORDER BY equipment_variety DESC;

-- 6. Inquiry 4 — Members with NO reservations in April 2026
SELECT
    m.member_id,
    m.name,
    m.corporate_affiliation
FROM  Member m
LEFT JOIN Reservation r ON m.member_id = r.member_id
    AND MONTH(r.reservation_date) = 4
    AND YEAR(r.reservation_date)  = 2026
WHERE r.reservation_id IS NULL;

-- 7. Inquiry 5 — Equipment used in each hub in April 2026
SELECT
    h.district_location     AS hub,
    e.type                  AS equipment_type,
    COUNT(r.reservation_id) AS times_used
FROM  Reservation r
JOIN  Workspace   w ON r.workspace_id = w.workspace_id
JOIN  Hub         h ON w.hub_id       = h.hub_id
JOIN  Equipment   e ON r.equipment_id = e.equipment_id
WHERE MONTH(r.reservation_date) = 4
  AND YEAR(r.reservation_date)  = 2026
GROUP BY h.district_location, e.type
ORDER BY h.district_location, times_used DESC;

-- 8. Inquiry 6 — Each member's full profile + total reservations + total spent
SELECT
    m.member_id,
    m.name,
    m.corporate_affiliation,
    COUNT(r.reservation_id) AS total_reservations,
    ISNULL(SUM(r.rate), 0)  AS total_amount_spent
FROM  Member m
LEFT JOIN Reservation r ON m.member_id = r.member_id
GROUP BY m.member_id, m.name, m.corporate_affiliation
ORDER BY total_reservations DESC;